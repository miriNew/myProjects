
using BlApi;


namespace BlImplementation
{
    internal class CustomerImplemention : ICustomer
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Customer item)
        {
            try
            {
                DO.Customer c1 = BO.Tools.convertCustomerBoToDo(item);
                return _dal.Customer.Create(c1);
            }catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {

                _dal.Customer.Delete(id);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public bool IsExist(int id)
        {
            try { 
            DO.Customer cust = _dal.Customer.Read(id);
                if(cust != null)
                {
                    return true;
                }
                return false;
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public BO.Customer? Read(int id)
        {
            try
            {
                BO.Customer p = BO.Tools.convertCustomerDoToBo(_dal.Customer.Read(id));
                return p;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            try
            {
                Func<DO.Customer, bool>? filterDO = null;
                if (filter != null)
                {
                    filterDO = c => filter(BO.Tools.convertCustomerDoToBo(c));
                }
                var data = _dal.Customer.ReadAll(filterDO);

                var customers = data.Select(c => BO.Tools.convertCustomerDoToBo(c)).ToList();

                return customers;
            }catch(Exception ex) { 
                throw new Exception(ex.Message);
            }
        }

        public void Update(BO.Customer item)
        {
            try
            {
                DO.Customer c1 = BO.Tools.convertCustomerBoToDo(item);
                _dal.Customer.Update(c1);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
