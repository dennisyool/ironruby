describe :uninstantiable_class, :shared => true do 
  it "are not be able to be instantiated" do
    lambda { @method.new }.should raise_error(TypeError, /allocator/)
  end
end
