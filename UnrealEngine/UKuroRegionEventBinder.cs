using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000347 RID: 839
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.KuroRegionEventBinder")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroRegionEventBinder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005635 RID: 22069 RVA: 0x00078D66 File Offset: 0x00076F66
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRegionEventBinder._ClassPtr;
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x00078D74 File Offset: 0x00076F74
		public UKuroRegionEventBinder() : this(BuiltinUtils.AllocNativeUObject(UKuroRegionEventBinder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x00078D9C File Offset: 0x00076F9C
		public UKuroRegionEventBinder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRegionEventBinder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06005638 RID: 22072 RVA: 0x00078DCF File Offset: 0x00076FCF
		// (set) Token: 0x06005639 RID: 22073 RVA: 0x00078DE3 File Offset: 0x00076FE3
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

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x0600563A RID: 22074 RVA: 0x00078DF8 File Offset: 0x00076FF8
		// (set) Token: 0x0600563B RID: 22075 RVA: 0x00078E31 File Offset: 0x00077031
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

		// Token: 0x0600563C RID: 22076 RVA: 0x00078E52 File Offset: 0x00077052
		static UKuroRegionEventBinder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroRegionEventBinder");
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x00078E60 File Offset: 0x00077060
		protected UKuroRegionEventBinder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002358 RID: 9048
		public new const string __ObjectPath = "/Script/KuroComponent.KuroRegionEventBinder";

		// Token: 0x04002359 RID: 9049
		private static IntPtr _ClassPtr;

		// Token: 0x0400235A RID: 9050
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400235B RID: 9051
		internal static int __PropertyOffset_RegionName;

		// Token: 0x0400235C RID: 9052
		internal static int __PropertyOffset_Callback;

		// Token: 0x0400235D RID: 9053
		[Nullable(2)]
		private FRegionEventTrigger _Callback;
	}
}
