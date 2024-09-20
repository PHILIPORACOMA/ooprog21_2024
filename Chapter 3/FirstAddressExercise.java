public class FirstAddressExercise {

    public static void main(String[] args) {
        
        Company company = new Company();

        company.setCompanyName("Google Pixel");
        company.setStreetAddress("1600 Amphitheatre Parkway");
        company.setZip("Mountain View, CA 94043");
        company.setBrand("Google LLC");
        
        displayAddress(company);
    }
    public static void displayAddress(Company company) {
        System.out.println(company.getCompanyName());
        System.out.println(company.getStreetAddress());
        System.out.println(company.getZip());
        System.out.println("Company: " + company.getBrand());
    }
}
class Company {
    private String companyName;
    private String streetAddress;
    private String Zip;
    private String brand;
    
    public String getCompanyName() {
        return companyName;
    }

    public void setCompanyName(String companyName) {
        this.companyName = companyName;
    }

    public String getStreetAddress() {
        return streetAddress;
    }

    public void setStreetAddress(String streetAddress) {
        this.streetAddress = streetAddress;
    }

    public String getZip() {
        return Zip;
    }

    public void setZip(String Zip) {
        this.Zip = Zip;
    }

    public String getBrand() {
        return brand;
    }

    public void setBrand(String brand) {
        this.brand = brand;
    }
}