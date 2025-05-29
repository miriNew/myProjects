import click
from repository import Repository

repo = Repository()


@click.group()
def cli():
    """Wit version control commands"""
    pass


@cli.command()
def init():
    """Initialize a new repository"""
    print("Running init command...")
    repo.wit_init()
    print("Repository initialized.")


@cli.command()
@click.argument('file_name')
def add(file_name):
    """Add a file to the staging area"""
    repo.wit_add(file_name)
    print(f"File {file_name} added to staging area.")


@cli.command()
@click.argument('message')
def commit(message):
    """Commit changes with a message"""
    repo.wit_commit(message)
    print("Commit created.")


@cli.command()
def log():
    """Show the log of all commits"""
    repo.wit_log()


@cli.command()
def status():
    """Show the status of the repository"""
    repo.wit_status()


@cli.command()
@click.argument('hash_code')
def checkout(hash_code):
    """Checkout a specific commit"""
    repo.wit_checkout(hash_code)
    print(f"Checked out commit {hash_code}.")


if __name__ == "__main__":
    cli()
