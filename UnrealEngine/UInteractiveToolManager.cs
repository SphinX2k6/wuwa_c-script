using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200157C RID: 5500
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractiveToolManager")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 408)]
	public class UInteractiveToolManager : UObject, IUnrealUObject, IUnrealObject, IToolContextTransactionProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06013E10 RID: 81424 RVA: 0x001D3075 File Offset: 0x001D1275
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveToolManager._ClassPtr;
		}

		// Token: 0x06013E11 RID: 81425 RVA: 0x001D3081 File Offset: 0x001D1281
		int IToolContextTransactionProvider.InterfaceOffset()
		{
			return UInteractiveToolManager.__InterfaceOffset_IToolContextTransactionProvider;
		}

		// Token: 0x06013E12 RID: 81426 RVA: 0x001D3088 File Offset: 0x001D1288
		public UInteractiveToolManager() : this(BuiltinUtils.AllocNativeUObject(UInteractiveToolManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E13 RID: 81427 RVA: 0x001D30B0 File Offset: 0x001D12B0
		[NullableContext(1)]
		public UInteractiveToolManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInteractiveToolManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004DD5 RID: 19925
		// (get) Token: 0x06013E14 RID: 81428 RVA: 0x001D30E3 File Offset: 0x001D12E3
		// (set) Token: 0x06013E15 RID: 81429 RVA: 0x001D30F7 File Offset: 0x001D12F7
		[Nullable(2)]
		public unsafe UInteractiveTool ActiveLeftTool
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInteractiveTool>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolManager.__PropertyOffset_ActiveLeftTool);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolManager.__PropertyOffset_ActiveLeftTool, value);
			}
		}

		// Token: 0x17004DD6 RID: 19926
		// (get) Token: 0x06013E16 RID: 81430 RVA: 0x001D310C File Offset: 0x001D130C
		// (set) Token: 0x06013E17 RID: 81431 RVA: 0x001D3120 File Offset: 0x001D1320
		[Nullable(2)]
		public unsafe UInteractiveTool ActiveRightTool
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInteractiveTool>(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolManager.__PropertyOffset_ActiveRightTool);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInteractiveToolManager.__PropertyOffset_ActiveRightTool, value);
			}
		}

		// Token: 0x17004DD7 RID: 19927
		// (get) Token: 0x06013E18 RID: 81432 RVA: 0x001D3138 File Offset: 0x001D1338
		// (set) Token: 0x06013E19 RID: 81433 RVA: 0x001D3171 File Offset: 0x001D1371
		[Nullable(1)]
		public TMap<string, UInteractiveToolBuilder> ToolBuilders
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<string, UInteractiveToolBuilder> result;
				if ((result = this._ToolBuilders) == null)
				{
					result = (this._ToolBuilders = new TMap<string, UInteractiveToolBuilder>(base.NativePtr + (IntPtr)UInteractiveToolManager.__PropertyOffset_ToolBuilders, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ToolBuilders.CopyAssign(value);
			}
		}

		// Token: 0x06013E1A RID: 81434 RVA: 0x001D317F File Offset: 0x001D137F
		static UInteractiveToolManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InteractiveToolManager");
		}

		// Token: 0x06013E1B RID: 81435 RVA: 0x001D318D File Offset: 0x001D138D
		protected UInteractiveToolManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC1A RID: 44058
		internal static int __InterfaceOffset_IToolContextTransactionProvider;

		// Token: 0x0400AC1B RID: 44059
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractiveToolManager";

		// Token: 0x0400AC1C RID: 44060
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC1D RID: 44061
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AC1E RID: 44062
		internal static int __PropertyOffset_ActiveLeftTool;

		// Token: 0x0400AC1F RID: 44063
		internal static int __PropertyOffset_ActiveRightTool;

		// Token: 0x0400AC20 RID: 44064
		internal static int __PropertyOffset_ToolBuilders;

		// Token: 0x0400AC21 RID: 44065
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UInteractiveToolBuilder> _ToolBuilders;
	}
}
