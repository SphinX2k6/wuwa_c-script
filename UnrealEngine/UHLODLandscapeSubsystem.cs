using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C36 RID: 3126
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HLODLandscapeSubsystem")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UHLODLandscapeSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E6C RID: 40556 RVA: 0x000E128A File Offset: 0x000DF48A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHLODLandscapeSubsystem._ClassPtr;
		}

		// Token: 0x06009E6D RID: 40557 RVA: 0x000E1298 File Offset: 0x000DF498
		public UHLODLandscapeSubsystem() : this(BuiltinUtils.AllocNativeUObject(UHLODLandscapeSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E6E RID: 40558 RVA: 0x000E12C0 File Offset: 0x000DF4C0
		public UHLODLandscapeSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHLODLandscapeSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x06009E6F RID: 40559 RVA: 0x000E12F4 File Offset: 0x000DF4F4
		// (set) Token: 0x06009E70 RID: 40560 RVA: 0x000E132D File Offset: 0x000DF52D
		public FOnLandscapeStreamingProxyEvt OnTriggerProxyShown
		{
			get
			{
				base.FastCheckIsValid();
				FOnLandscapeStreamingProxyEvt result;
				if ((result = this._OnTriggerProxyShown) == null)
				{
					result = (this._OnTriggerProxyShown = new FOnLandscapeStreamingProxyEvt(base.NativePtr + (IntPtr)UHLODLandscapeSubsystem.__PropertyOffset_OnTriggerProxyShown, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UHLODLandscapeSubsystem.__PropertyOffset_OnTriggerProxyShown, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170025D8 RID: 9688
		// (get) Token: 0x06009E71 RID: 40561 RVA: 0x000E1350 File Offset: 0x000DF550
		// (set) Token: 0x06009E72 RID: 40562 RVA: 0x000E1389 File Offset: 0x000DF589
		public FOnLandscapeStreamingProxyEvt OnTriggerProxyHide
		{
			get
			{
				base.FastCheckIsValid();
				FOnLandscapeStreamingProxyEvt result;
				if ((result = this._OnTriggerProxyHide) == null)
				{
					result = (this._OnTriggerProxyHide = new FOnLandscapeStreamingProxyEvt(base.NativePtr + (IntPtr)UHLODLandscapeSubsystem.__PropertyOffset_OnTriggerProxyHide, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UHLODLandscapeSubsystem.__PropertyOffset_OnTriggerProxyHide, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x000E13AA File Offset: 0x000DF5AA
		public TMap<FName, ALandscapeStreamingProxy> GetAllKuroLandscapeStreamingProxies()
		{
			return new TMap<FName, ALandscapeStreamingProxy>(UHLODLandscapeSubsystem.__GetAllKuroLandscapeStreamingProxies_Internal(base.NativePtr), null);
		}

		// Token: 0x06009E74 RID: 40564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllKuroLandscapeStreamingProxies_Internal(IntPtr @this);

		// Token: 0x06009E75 RID: 40565 RVA: 0x000E13BD File Offset: 0x000DF5BD
		static UHLODLandscapeSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HLODLandscapeSubsystem");
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x000E13CB File Offset: 0x000DF5CB
		protected UHLODLandscapeSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005753 RID: 22355
		public new const string __ObjectPath = "/Script/Engine.HLODLandscapeSubsystem";

		// Token: 0x04005754 RID: 22356
		private static IntPtr _ClassPtr;

		// Token: 0x04005755 RID: 22357
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005756 RID: 22358
		public static IntPtr __OnLandscapeStreamingProxyEvt__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005757 RID: 22359
		internal static int __PropertyOffset_OnTriggerProxyShown;

		// Token: 0x04005758 RID: 22360
		[Nullable(2)]
		private FOnLandscapeStreamingProxyEvt _OnTriggerProxyShown;

		// Token: 0x04005759 RID: 22361
		internal static int __PropertyOffset_OnTriggerProxyHide;

		// Token: 0x0400575A RID: 22362
		[Nullable(2)]
		private FOnLandscapeStreamingProxyEvt _OnTriggerProxyHide;
	}
}
