using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C3 RID: 451
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DataLayerSubsystem")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UDataLayerSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020F8 RID: 8440 RVA: 0x00030695 File Offset: 0x0002E895
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataLayerSubsystem._ClassPtr;
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000306A4 File Offset: 0x0002E8A4
		public UDataLayerSubsystem() : this(BuiltinUtils.AllocNativeUObject(UDataLayerSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000306CC File Offset: 0x0002E8CC
		public UDataLayerSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataLayerSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060020FB RID: 8443 RVA: 0x00030700 File Offset: 0x0002E900
		// (set) Token: 0x060020FC RID: 8444 RVA: 0x00030739 File Offset: 0x0002E939
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

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060020FD RID: 8445 RVA: 0x0003075C File Offset: 0x0002E95C
		// (set) Token: 0x060020FE RID: 8446 RVA: 0x00030795 File Offset: 0x0002E995
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

		// Token: 0x060020FF RID: 8447 RVA: 0x000307B6 File Offset: 0x0002E9B6
		public TArray<string> GetAllDataLayerLabels()
		{
			return new TArray<string>(UDataLayerSubsystem.__GetAllDataLayerLabels_Internal(base.NativePtr), null);
		}

		// Token: 0x06002100 RID: 8448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllDataLayerLabels_Internal(IntPtr @this);

		// Token: 0x06002101 RID: 8449 RVA: 0x000307C9 File Offset: 0x0002E9C9
		static UDataLayerSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataLayerSubsystem");
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000307D7 File Offset: 0x0002E9D7
		protected UDataLayerSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AF7 RID: 2807
		public new const string __ObjectPath = "/Script/Engine.DataLayerSubsystem";

		// Token: 0x04000AF8 RID: 2808
		private static IntPtr _ClassPtr;

		// Token: 0x04000AF9 RID: 2809
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000AFA RID: 2810
		internal static int __PropertyOffset_OnGlobalDataLayerActivationStateChanged;

		// Token: 0x04000AFB RID: 2811
		[Nullable(2)]
		private FOnGlobalDataLayerActivationStateChanged _OnGlobalDataLayerActivationStateChanged;

		// Token: 0x04000AFC RID: 2812
		internal static int __PropertyOffset_OnGlobalDataLayerStateChanged;

		// Token: 0x04000AFD RID: 2813
		[Nullable(2)]
		private FOnGlobalDataLayerStateChanged _OnGlobalDataLayerStateChanged;
	}
}
