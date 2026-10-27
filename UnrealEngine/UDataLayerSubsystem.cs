using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200099C RID: 2460
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DataLayerSubsystem")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UDataLayerSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008AE5 RID: 35557 RVA: 0x000C6F5A File Offset: 0x000C515A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataLayerSubsystem._ClassPtr;
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x000C6F68 File Offset: 0x000C5168
		public UDataLayerSubsystem() : this(BuiltinUtils.AllocNativeUObject(UDataLayerSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008AE7 RID: 35559 RVA: 0x000C6F90 File Offset: 0x000C5190
		public UDataLayerSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataLayerSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06008AE8 RID: 35560 RVA: 0x000C6FC4 File Offset: 0x000C51C4
		// (set) Token: 0x06008AE9 RID: 35561 RVA: 0x000C6FFD File Offset: 0x000C51FD
		public FOnGlobalDataLayerActivationStateChanged OnGlobalDataLayerActivationStateChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnGlobalDataLayerActivationStateChanged result;
				if ((result = this._OnGlobalDataLayerActivationStateChanged) == null)
				{
					result = (this._OnGlobalDataLayerActivationStateChanged = new FOnGlobalDataLayerActivationStateChanged(base.NativePtr + (IntPtr)UDataLayerSubsystem.__PropertyOffset_OnGlobalDataLayerActivationStateChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UDataLayerSubsystem.__PropertyOffset_OnGlobalDataLayerActivationStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06008AEA RID: 35562 RVA: 0x000C7020 File Offset: 0x000C5220
		// (set) Token: 0x06008AEB RID: 35563 RVA: 0x000C7059 File Offset: 0x000C5259
		public FOnGlobalDataLayerStateChanged OnGlobalDataLayerStateChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnGlobalDataLayerStateChanged result;
				if ((result = this._OnGlobalDataLayerStateChanged) == null)
				{
					result = (this._OnGlobalDataLayerStateChanged = new FOnGlobalDataLayerStateChanged(base.NativePtr + (IntPtr)UDataLayerSubsystem.__PropertyOffset_OnGlobalDataLayerStateChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UDataLayerSubsystem.__PropertyOffset_OnGlobalDataLayerStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06008AEC RID: 35564 RVA: 0x000C707A File Offset: 0x000C527A
		public TArray<string> GetAllDataLayerLabels()
		{
			return new TArray<string>(UDataLayerSubsystem.__GetAllDataLayerLabels_Internal(base.NativePtr), null);
		}

		// Token: 0x06008AED RID: 35565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllDataLayerLabels_Internal(IntPtr @this);

		// Token: 0x06008AEE RID: 35566 RVA: 0x000C708D File Offset: 0x000C528D
		static UDataLayerSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataLayerSubsystem");
		}

		// Token: 0x06008AEF RID: 35567 RVA: 0x000C709B File Offset: 0x000C529B
		protected UDataLayerSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041F7 RID: 16887
		public new const string __ObjectPath = "/Script/Engine.DataLayerSubsystem";

		// Token: 0x040041F8 RID: 16888
		private static IntPtr _ClassPtr;

		// Token: 0x040041F9 RID: 16889
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041FA RID: 16890
		internal static int __PropertyOffset_OnGlobalDataLayerActivationStateChanged;

		// Token: 0x040041FB RID: 16891
		[Nullable(2)]
		private FOnGlobalDataLayerActivationStateChanged _OnGlobalDataLayerActivationStateChanged;

		// Token: 0x040041FC RID: 16892
		internal static int __PropertyOffset_OnGlobalDataLayerStateChanged;

		// Token: 0x040041FD RID: 16893
		[Nullable(2)]
		private FOnGlobalDataLayerStateChanged _OnGlobalDataLayerStateChanged;
	}
}
