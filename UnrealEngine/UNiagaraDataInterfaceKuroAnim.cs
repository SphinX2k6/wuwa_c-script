using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C0D RID: 7181
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.NiagaraDataInterfaceKuroAnim")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfaceKuroAnim : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BB52 RID: 113490 RVA: 0x0028C77F File Offset: 0x0028A97F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceKuroAnim._ClassPtr;
		}

		// Token: 0x0601BB53 RID: 113491 RVA: 0x0028C78C File Offset: 0x0028A98C
		public UNiagaraDataInterfaceKuroAnim() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceKuroAnim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BB54 RID: 113492 RVA: 0x0028C7B4 File Offset: 0x0028A9B4
		public UNiagaraDataInterfaceKuroAnim(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceKuroAnim.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006FC1 RID: 28609
		// (get) Token: 0x0601BB55 RID: 113493 RVA: 0x0028C7E8 File Offset: 0x0028A9E8
		// (set) Token: 0x0601BB56 RID: 113494 RVA: 0x0028C821 File Offset: 0x0028AA21
		public TArray<FNdiKuroAnimAnimInfo> Anims
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNdiKuroAnimAnimInfo> result;
				if ((result = this._Anims) == null)
				{
					result = (this._Anims = new TArray<FNdiKuroAnimAnimInfo>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceKuroAnim.__PropertyOffset_Anims, this));
				}
				return result;
			}
			set
			{
				this.Anims.CopyAssign(value);
			}
		}

		// Token: 0x17006FC2 RID: 28610
		// (get) Token: 0x0601BB57 RID: 113495 RVA: 0x0028C830 File Offset: 0x0028AA30
		// (set) Token: 0x0601BB58 RID: 113496 RVA: 0x0028C869 File Offset: 0x0028AA69
		public TArray<FNdiKuroAnimTransitionInfo> Transitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNdiKuroAnimTransitionInfo> result;
				if ((result = this._Transitions) == null)
				{
					result = (this._Transitions = new TArray<FNdiKuroAnimTransitionInfo>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceKuroAnim.__PropertyOffset_Transitions, this));
				}
				return result;
			}
			set
			{
				this.Transitions.CopyAssign(value);
			}
		}

		// Token: 0x17006FC3 RID: 28611
		// (get) Token: 0x0601BB59 RID: 113497 RVA: 0x0028C877 File Offset: 0x0028AA77
		// (set) Token: 0x0601BB5A RID: 113498 RVA: 0x0028C88B File Offset: 0x0028AA8B
		[Nullable(2)]
		public unsafe UKuroPointCloudCache RootMotionData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudCache>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceKuroAnim.__PropertyOffset_RootMotionData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceKuroAnim.__PropertyOffset_RootMotionData, value);
			}
		}

		// Token: 0x0601BB5B RID: 113499 RVA: 0x0028C8A0 File Offset: 0x0028AAA0
		public static void WriteBirdAudioDataThreadSafe([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FKuroBirdAudioData> InData)
		{
			UNiagaraDataInterfaceKuroAnim.__WriteBirdAudioDataThreadSafe_Internal((InData ?? new TArray<FKuroBirdAudioData>()).NativePtr);
		}

		// Token: 0x0601BB5C RID: 113500 RVA: 0x0028C8B7 File Offset: 0x0028AAB7
		public static void ReadBirdAudioDataThreadSafe([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKuroBirdAudioData> OutData)
		{
			UNiagaraDataInterfaceKuroAnim.__ReadBirdAudioDataThreadSafe_Internal((OutData ?? new TArray<FKuroBirdAudioData>()).NativePtr);
		}

		// Token: 0x0601BB5D RID: 113501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WriteBirdAudioDataThreadSafe_Internal(IntPtr InData);

		// Token: 0x0601BB5E RID: 113502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReadBirdAudioDataThreadSafe_Internal(IntPtr OutData);

		// Token: 0x0601BB5F RID: 113503 RVA: 0x0028C8CE File Offset: 0x0028AACE
		static UNiagaraDataInterfaceKuroAnim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.NiagaraDataInterfaceKuroAnim");
		}

		// Token: 0x0601BB60 RID: 113504 RVA: 0x0028C8DC File Offset: 0x0028AADC
		protected UNiagaraDataInterfaceKuroAnim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EE6A RID: 61034
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.NiagaraDataInterfaceKuroAnim";

		// Token: 0x0400EE6B RID: 61035
		private static IntPtr _ClassPtr;

		// Token: 0x0400EE6C RID: 61036
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EE6D RID: 61037
		internal static int __PropertyOffset_Anims;

		// Token: 0x0400EE6E RID: 61038
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNdiKuroAnimAnimInfo> _Anims;

		// Token: 0x0400EE6F RID: 61039
		internal static int __PropertyOffset_Transitions;

		// Token: 0x0400EE70 RID: 61040
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNdiKuroAnimTransitionInfo> _Transitions;

		// Token: 0x0400EE71 RID: 61041
		internal static int __PropertyOffset_RootMotionData;
	}
}
