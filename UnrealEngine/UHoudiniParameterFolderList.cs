using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014F0 RID: 5360
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterFolderList")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UHoudiniParameterFolderList : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060136C7 RID: 79559 RVA: 0x001C8E8B File Offset: 0x001C708B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterFolderList._ClassPtr;
		}

		// Token: 0x060136C8 RID: 79560 RVA: 0x001C8E98 File Offset: 0x001C7098
		public UHoudiniParameterFolderList() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterFolderList.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060136C9 RID: 79561 RVA: 0x001C8EC0 File Offset: 0x001C70C0
		public UHoudiniParameterFolderList(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterFolderList.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BD7 RID: 19415
		// (get) Token: 0x060136CA RID: 79562 RVA: 0x001C8EF3 File Offset: 0x001C70F3
		// (set) Token: 0x060136CB RID: 79563 RVA: 0x001C8F03 File Offset: 0x001C7103
		public unsafe bool bIsTabMenu
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFolderList.__PropertyOffset_bIsTabMenu) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFolderList.__PropertyOffset_bIsTabMenu) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BD8 RID: 19416
		// (get) Token: 0x060136CC RID: 79564 RVA: 0x001C8F14 File Offset: 0x001C7114
		// (set) Token: 0x060136CD RID: 79565 RVA: 0x001C8F24 File Offset: 0x001C7124
		public unsafe bool bIsTabsShown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterFolderList.__PropertyOffset_bIsTabsShown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterFolderList.__PropertyOffset_bIsTabsShown) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BD9 RID: 19417
		// (get) Token: 0x060136CE RID: 79566 RVA: 0x001C8F38 File Offset: 0x001C7138
		// (set) Token: 0x060136CF RID: 79567 RVA: 0x001C8F71 File Offset: 0x001C7171
		public TArray<UHoudiniParameterFolder> TabFolders
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniParameterFolder> result;
				if ((result = this._TabFolders) == null)
				{
					result = (this._TabFolders = new TArray<UHoudiniParameterFolder>(base.NativePtr + (IntPtr)UHoudiniParameterFolderList.__PropertyOffset_TabFolders, this));
				}
				return result;
			}
			set
			{
				this.TabFolders.CopyAssign(value);
			}
		}

		// Token: 0x060136D0 RID: 79568 RVA: 0x001C8F7F File Offset: 0x001C717F
		static UHoudiniParameterFolderList()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterFolderList");
		}

		// Token: 0x060136D1 RID: 79569 RVA: 0x001C8F8D File Offset: 0x001C718D
		protected UHoudiniParameterFolderList(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A7EF RID: 42991
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterFolderList";

		// Token: 0x0400A7F0 RID: 42992
		private static IntPtr _ClassPtr;

		// Token: 0x0400A7F1 RID: 42993
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A7F2 RID: 42994
		internal static int __PropertyOffset_bIsTabMenu;

		// Token: 0x0400A7F3 RID: 42995
		internal static int __PropertyOffset_bIsTabsShown;

		// Token: 0x0400A7F4 RID: 42996
		internal static int __PropertyOffset_TabFolders;

		// Token: 0x0400A7F5 RID: 42997
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniParameterFolder> _TabFolders;
	}
}
