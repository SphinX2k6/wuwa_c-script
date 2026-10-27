using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000F2 RID: 242
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.AIPerceptionComponent")]
	[UnrealStructLayout(424, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 424)]
	public class UAIPerceptionComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012F0 RID: 4848 RVA: 0x0001C0A0 File Offset: 0x0001A2A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIPerceptionComponent._ClassPtr;
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0001C0AC File Offset: 0x0001A2AC
		public UAIPerceptionComponent() : this(BuiltinUtils.AllocNativeUObject(UAIPerceptionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x0001C0D4 File Offset: 0x0001A2D4
		public UAIPerceptionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIPerceptionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x0001C108 File Offset: 0x0001A308
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x0001C141 File Offset: 0x0001A341
		public TArray<UAISenseConfig> SensesConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UAISenseConfig> result;
				if ((result = this._SensesConfig) == null)
				{
					result = (this._SensesConfig = new TArray<UAISenseConfig>(base.NativePtr + (IntPtr)UAIPerceptionComponent.__PropertyOffset_SensesConfig, this));
				}
				return result;
			}
			set
			{
				this.SensesConfig.CopyAssign(value);
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x0001C14F File Offset: 0x0001A34F
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x0001C163 File Offset: 0x0001A363
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAISense> DominantSense
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UAIPerceptionComponent.__PropertyOffset_DominantSense);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UAIPerceptionComponent.__PropertyOffset_DominantSense) = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x0001C178 File Offset: 0x0001A378
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x0001C18C File Offset: 0x0001A38C
		[Nullable(2)]
		public unsafe AAIController AIOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AAIController>(base.NativePtr / (IntPtr)sizeof(void*) + UAIPerceptionComponent.__PropertyOffset_AIOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAIPerceptionComponent.__PropertyOffset_AIOwner, value);
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060012F9 RID: 4857 RVA: 0x0001C1A4 File Offset: 0x0001A3A4
		// (set) Token: 0x060012FA RID: 4858 RVA: 0x0001C1DD File Offset: 0x0001A3DD
		public FPerceptionUpdatedDelegate OnPerceptionUpdated
		{
			get
			{
				base.FastCheckIsValid();
				FPerceptionUpdatedDelegate result;
				if ((result = this._OnPerceptionUpdated) == null)
				{
					result = (this._OnPerceptionUpdated = new FPerceptionUpdatedDelegate(base.NativePtr + (IntPtr)UAIPerceptionComponent.__PropertyOffset_OnPerceptionUpdated, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAIPerceptionComponent.__PropertyOffset_OnPerceptionUpdated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060012FB RID: 4859 RVA: 0x0001C200 File Offset: 0x0001A400
		// (set) Token: 0x060012FC RID: 4860 RVA: 0x0001C239 File Offset: 0x0001A439
		public FActorPerceptionUpdatedDelegate OnTargetPerceptionUpdated
		{
			get
			{
				base.FastCheckIsValid();
				FActorPerceptionUpdatedDelegate result;
				if ((result = this._OnTargetPerceptionUpdated) == null)
				{
					result = (this._OnTargetPerceptionUpdated = new FActorPerceptionUpdatedDelegate(base.NativePtr + (IntPtr)UAIPerceptionComponent.__PropertyOffset_OnTargetPerceptionUpdated, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAIPerceptionComponent.__PropertyOffset_OnTargetPerceptionUpdated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060012FD RID: 4861 RVA: 0x0001C25C File Offset: 0x0001A45C
		// (set) Token: 0x060012FE RID: 4862 RVA: 0x0001C295 File Offset: 0x0001A495
		public FActorPerceptionInfoUpdatedDelegate OnTargetPerceptionInfoUpdated
		{
			get
			{
				base.FastCheckIsValid();
				FActorPerceptionInfoUpdatedDelegate result;
				if ((result = this._OnTargetPerceptionInfoUpdated) == null)
				{
					result = (this._OnTargetPerceptionInfoUpdated = new FActorPerceptionInfoUpdatedDelegate(base.NativePtr + (IntPtr)UAIPerceptionComponent.__PropertyOffset_OnTargetPerceptionInfoUpdated, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAIPerceptionComponent.__PropertyOffset_OnTargetPerceptionInfoUpdated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x0001C2B6 File Offset: 0x0001A4B6
		public void SetSenseEnabled([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAISense> SenseClass, bool bEnable)
		{
			UAIPerceptionComponent.__SetSenseEnabled_Internal(base.NativePtr, SenseClass._NativePtr, bEnable);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x0001C2CA File Offset: 0x0001A4CA
		public void RequestStimuliListenerUpdate()
		{
			UAIPerceptionComponent.__RequestStimuliListenerUpdate_Internal(base.NativePtr);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x0001C2D7 File Offset: 0x0001A4D7
		[NullableContext(2)]
		public void OnOwnerEndPlay(AActor Actor, EEndPlayReason EndPlayReason)
		{
			UAIPerceptionComponent.__OnOwnerEndPlay_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, EndPlayReason);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x0001C2FA File Offset: 0x0001A4FA
		public void GetPerceivedHostileActorsBySense([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAISense> SenseToUse, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UAIPerceptionComponent.__GetPerceivedHostileActorsBySense_Internal(base.NativePtr, SenseToUse._NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x0001C31D File Offset: 0x0001A51D
		public void GetPerceivedHostileActors([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UAIPerceptionComponent.__GetPerceivedHostileActors_Internal(base.NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x0001C33A File Offset: 0x0001A53A
		public void GetPerceivedActors([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAISense> SenseToUse, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UAIPerceptionComponent.__GetPerceivedActors_Internal(base.NativePtr, SenseToUse._NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0001C35D File Offset: 0x0001A55D
		public void GetKnownPerceivedActors([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAISense> SenseToUse, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UAIPerceptionComponent.__GetKnownPerceivedActors_Internal(base.NativePtr, SenseToUse._NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x0001C380 File Offset: 0x0001A580
		public void GetCurrentlyPerceivedActors([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UAISense> SenseToUse, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<AActor> OutActors)
		{
			UAIPerceptionComponent.__GetCurrentlyPerceivedActors_Internal(base.NativePtr, SenseToUse._NativePtr, (OutActors ?? new TArray<AActor>()).NativePtr);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0001C3A3 File Offset: 0x0001A5A3
		[NullableContext(2)]
		public bool GetActorsPerception(AActor Actor, ref FActorPerceptionBlueprintInfo Info)
		{
			return UAIPerceptionComponent.__GetActorsPerception_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, (Info ?? new FActorPerceptionBlueprintInfo()).NativePtr);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
		public void ForgetAll()
		{
			UAIPerceptionComponent.__ForgetAll_Internal(base.NativePtr);
		}

		// Token: 0x06001309 RID: 4873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSenseEnabled_Internal(IntPtr @this, IntPtr SenseClass, bool bEnable);

		// Token: 0x0600130A RID: 4874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestStimuliListenerUpdate_Internal(IntPtr @this);

		// Token: 0x0600130B RID: 4875
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnOwnerEndPlay_Internal(IntPtr @this, IntPtr Actor, TEnumAsByte<EEndPlayReason> EndPlayReason);

		// Token: 0x0600130C RID: 4876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPerceivedHostileActorsBySense_Internal(IntPtr @this, IntPtr SenseToUse, IntPtr OutActors);

		// Token: 0x0600130D RID: 4877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPerceivedHostileActors_Internal(IntPtr @this, IntPtr OutActors);

		// Token: 0x0600130E RID: 4878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetPerceivedActors_Internal(IntPtr @this, IntPtr SenseToUse, IntPtr OutActors);

		// Token: 0x0600130F RID: 4879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetKnownPerceivedActors_Internal(IntPtr @this, IntPtr SenseToUse, IntPtr OutActors);

		// Token: 0x06001310 RID: 4880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetCurrentlyPerceivedActors_Internal(IntPtr @this, IntPtr SenseToUse, IntPtr OutActors);

		// Token: 0x06001311 RID: 4881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActorsPerception_Internal(IntPtr @this, IntPtr Actor, IntPtr Info);

		// Token: 0x06001312 RID: 4882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForgetAll_Internal(IntPtr @this);

		// Token: 0x06001313 RID: 4883 RVA: 0x0001C3DD File Offset: 0x0001A5DD
		static UAIPerceptionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIPerceptionComponent");
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0001C3EB File Offset: 0x0001A5EB
		protected UAIPerceptionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400035A RID: 858
		public new const string __ObjectPath = "/Script/AIModule.AIPerceptionComponent";

		// Token: 0x0400035B RID: 859
		private static IntPtr _ClassPtr;

		// Token: 0x0400035C RID: 860
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400035D RID: 861
		internal static int __PropertyOffset_SensesConfig;

		// Token: 0x0400035E RID: 862
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UAISenseConfig> _SensesConfig;

		// Token: 0x0400035F RID: 863
		internal static int __PropertyOffset_DominantSense;

		// Token: 0x04000360 RID: 864
		internal static int __PropertyOffset_AIOwner;

		// Token: 0x04000361 RID: 865
		internal static int __PropertyOffset_OnPerceptionUpdated;

		// Token: 0x04000362 RID: 866
		[Nullable(2)]
		private FPerceptionUpdatedDelegate _OnPerceptionUpdated;

		// Token: 0x04000363 RID: 867
		internal static int __PropertyOffset_OnTargetPerceptionUpdated;

		// Token: 0x04000364 RID: 868
		[Nullable(2)]
		private FActorPerceptionUpdatedDelegate _OnTargetPerceptionUpdated;

		// Token: 0x04000365 RID: 869
		internal static int __PropertyOffset_OnTargetPerceptionInfoUpdated;

		// Token: 0x04000366 RID: 870
		[Nullable(2)]
		private FActorPerceptionInfoUpdatedDelegate _OnTargetPerceptionInfoUpdated;
	}
}
