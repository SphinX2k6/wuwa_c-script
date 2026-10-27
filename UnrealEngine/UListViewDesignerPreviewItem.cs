using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002981 RID: 10625
	[UnrealObjectPath("/Script/UMG.ListViewDesignerPreviewItem")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UListViewDesignerPreviewItem : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027542 RID: 161090 RVA: 0x003BF51D File Offset: 0x003BD71D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UListViewDesignerPreviewItem._ClassPtr;
		}

		// Token: 0x06027543 RID: 161091 RVA: 0x003BF52C File Offset: 0x003BD72C
		public UListViewDesignerPreviewItem() : this(BuiltinUtils.AllocNativeUObject(UListViewDesignerPreviewItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027544 RID: 161092 RVA: 0x003BF554 File Offset: 0x003BD754
		[NullableContext(1)]
		public UListViewDesignerPreviewItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UListViewDesignerPreviewItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027545 RID: 161093 RVA: 0x003BF587 File Offset: 0x003BD787
		static UListViewDesignerPreviewItem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ListViewDesignerPreviewItem");
		}

		// Token: 0x06027546 RID: 161094 RVA: 0x003BF595 File Offset: 0x003BD795
		protected UListViewDesignerPreviewItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015988 RID: 88456
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.ListViewDesignerPreviewItem";

		// Token: 0x04015989 RID: 88457
		private static IntPtr _ClassPtr;

		// Token: 0x0401598A RID: 88458
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
