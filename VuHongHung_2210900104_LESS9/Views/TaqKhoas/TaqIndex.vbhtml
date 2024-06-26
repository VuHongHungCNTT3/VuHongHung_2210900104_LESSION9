@ModelType IEnumerable(Of TRUONGANHQUAN_2210900058_LESS9.TaqKhoa)
@Code
    ViewData("Title") = "TaqIndex"
    Layout = "~/Views/Shared/_TaqLayout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Taq:Create New", "TaqCreate")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.TaqTenkhoa)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TaqTrangThai)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TaqTenkhoa)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TaqTrangThai)
        </td>
        <td>
            @Html.ActionLink("Taq:Edit", "TaqEdit", New With {.id = item.TaqMakhoa}) |
            @Html.ActionLink("Taq:Details", "TaqDetails", New With {.id = item.TaqMakhoa}) |
            @Html.ActionLink("Taq:Delete", "TaqDelete", New With {.id = item.TaqMakhoa})
        </td>
    </tr>
Next

</table>
