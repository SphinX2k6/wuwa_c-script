using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200175E RID: 5982
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionEventBinder")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroRegionEventBinder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601581F RID: 88095 RVA: 0x001F9AD6 File Offset: 0x001F7CD6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionEventBinder._ClassPtr;
		}

		// Token: 0x06015820 RID: 88096 RVA: 0x001F9AE4 File Offset: 0x001F7CE4
		public UKuroRegionEventBinder() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionEventBinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015821 RID: 88097 RVA: 0x001F9B0C File Offset: 0x001F7D0C
		public UKuroRegionEventBinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionEventBinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054EF RID: 21743
		// (get) Token: 0x06015822 RID: 88098 RVA: 0x001F9B3F File Offset: 0x001F7D3F
		// (set) Token: 0x06015823 RID: 88099 RVA: 0x001F9B53 File Offset: 0x001F7D53
		public unsafe string RegionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroRegionEventBinder.__PropertyOffset_RegionName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroRegionEventBinder.__PropertyOffset_RegionName)), value);
			}
		}

		// Token: 0x170054F0 RID: 21744
		// (get) Token: 0x06015824 RID: 88100 RVA: 0x001F9B68 File Offset: 0x001F7D68
		// (set) Token: 0x06015825 RID: 88101 RVA: 0x001F9BA1 File Offset: 0x001F7DA1
		public FRegionEventTrigger Callback
		{
			get
			{
				base.FastCheckIsValid();
				FRegionEventTrigger result;
				if ((result = this._Callback) == null)
				{
					result = (this._Callback = new FRegionEventTrigger(base.NativePtr + (IntPtr)UKuroRegionEventBinder.__PropertyOffset_Callback, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRegionEventBinder.__PropertyOffset_Callback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06015826 RID: 88102 RVA: 0x001F9BC2 File Offset: 0x001F7DC2
		static UKuroRegionEventBinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionEventBinder");
		}

		// Token: 0x06015827 RID: 88103 RVA: 0x001F9BD0 File Offset: 0x001F7DD0
		protected UKuroRegionEventBinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BBBE RID: 48062
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionEventBinder";

		// Token: 0x0400BBBF RID: 48063
		private static IntPtr _ClassPtr;

		// Token: 0x0400BBC0 RID: 48064
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BBC1 RID: 48065
		internal static int __PropertyOffset_RegionName;

		// Token: 0x0400BBC2 RID: 48066
		internal static int __PropertyOffset_Callback;

		// Token: 0x0400BBC3 RID: 48067
		[Nullable(2)]
		private FRegionEventTrigger _Callback;
	}
}
