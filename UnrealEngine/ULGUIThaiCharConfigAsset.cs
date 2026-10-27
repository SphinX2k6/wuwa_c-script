using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020020D7 RID: 8407
	[UnrealObjectPath("/Script/LGUI.LGUIThaiCharConfigAsset")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class ULGUIThaiCharConfigAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FAAB RID: 129707 RVA: 0x002F18B8 File Offset: 0x002EFAB8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIThaiCharConfigAsset._ClassPtr;
		}

		// Token: 0x0601FAAC RID: 129708 RVA: 0x002F18C4 File Offset: 0x002EFAC4
		public ULGUIThaiCharConfigAsset() : this(BuiltinUtils.AllocNativeUObject(ULGUIThaiCharConfigAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FAAD RID: 129709 RVA: 0x002F18EC File Offset: 0x002EFAEC
		[NullableContext(1)]
		public ULGUIThaiCharConfigAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUIThaiCharConfigAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007CD9 RID: 31961
		// (get) Token: 0x0601FAAE RID: 129710 RVA: 0x002F191F File Offset: 0x002EFB1F
		// (set) Token: 0x0601FAAF RID: 129711 RVA: 0x002F1933 File Offset: 0x002EFB33
		public unsafe FLGUIThaiCharConfig Config
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIThaiCharConfigAsset.__PropertyOffset_Config);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIThaiCharConfigAsset.__PropertyOffset_Config) = value;
			}
		}

		// Token: 0x0601FAB0 RID: 129712 RVA: 0x002F1948 File Offset: 0x002EFB48
		static ULGUIThaiCharConfigAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIThaiCharConfigAsset");
		}

		// Token: 0x0601FAB1 RID: 129713 RVA: 0x002F1956 File Offset: 0x002EFB56
		protected ULGUIThaiCharConfigAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011164 RID: 69988
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIThaiCharConfigAsset";

		// Token: 0x04011165 RID: 69989
		private static IntPtr _ClassPtr;

		// Token: 0x04011166 RID: 69990
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011167 RID: 69991
		internal static int __PropertyOffset_Config;
	}
}
