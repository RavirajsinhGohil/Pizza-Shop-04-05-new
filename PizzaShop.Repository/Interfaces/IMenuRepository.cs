using PizzaShop.Entity.Models;
using PizzaShop.Entity.ViewModel;

namespace PizzaShop.Repository.Interfaces;

public interface IMenuRepository
{
    Task<List<CategoryViewModel>> GetCategories();
    Task<Menucategory> GetCategorybyId(int categoryId);
    Task<List<ItemViewModel>> GetItems(int categoryId);
    Task<List<ModifierGroupViewModel>> GetModifierGroups();
    Task<List<ModifiersViewModel>> GetModifiers(int categoryId);
    Task AddCategory(Menucategory menucategory);
    Menucategory GetCategoryForEdit(int categoryId);
    Task<MenuItemViewModel> GetItemsByCategoryAsync(int categoryid, string searchTerm, int page, int pageSize);
    Task<MenuItemViewModel> GetModifierItemsByModifierGroupAsync(int categoryid, string searchTerm, int page, int pageSize);
    Task<bool> EditCategory(CategoryViewModel model);
    Task<bool> DeleteCategory(int categoryId);
    Task<bool> AddItem(Item item);
    Item GetItemById(int id);
    List<Menucategory> GetAllCategories();
    void UpdateItem(Item item);
    bool DeleteItem(int itemId);
    Task<List<Item>> GetModifiersForExistingModifiersForAdd(int pageNumber, int pageSize);
    Task<bool> AddModifierGroup(Modifiergroup modifiergroup);
    Modifiergroup GetModifierGroupById(int id);
    bool UpdateModifierGroup(Modifiergroup model);
    bool DeleteModifierGroup(Modifiergroup modifierGroup);
    Task<bool> AddItemModifierGroupMappings(Itemmodifiergroupmapping modifierMapping);
    Itemmodifiergroupmapping GetItemModifierGroupMappingsById(int modifierId, int modifierGroupId);
    Task<int> GetTotalCountOfModifierMapping();
    Task<List<ModifiersViewModel>> GetExistingModifiersForEdit(int id);
    Task<List<ModifierGroupViewModel>> GetModifierGroupsForEditModifier();
    Task<int> GetTotalCountOfItems();
    Task<int> GetTotalCountOfModifiers();
    Task<List<Itemmodifiergroupmapping>> GetModifierGroupsForEditItem(int itemId);
}