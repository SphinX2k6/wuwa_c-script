using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019B5 RID: 6581
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroLevelStateMachine.KuroLevelStateMachineComponent")]
	[UnrealStructLayout(720, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UKuroLevelStateMachineComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060187AC RID: 100268 RVA: 0x00241243 File Offset: 0x0023F443
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelStateMachineComponent._ClassPtr;
		}

		// Token: 0x060187AD RID: 100269 RVA: 0x00241250 File Offset: 0x0023F450
		public UKuroLevelStateMachineComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelStateMachineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060187AE RID: 100270 RVA: 0x00241278 File Offset: 0x0023F478
		[NullableContext(1)]
		public UKuroLevelStateMachineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelStateMachineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170061BF RID: 25023
		// (get) Token: 0x060187AF RID: 100271 RVA: 0x002412AB File Offset: 0x0023F4AB
		// (set) Token: 0x060187B0 RID: 100272 RVA: 0x002412C4 File Offset: 0x0023F4C4
		public unsafe bool bStartOnBeginPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroLevelStateMachineComponent.__PropertyOffset_bStartOnBeginPlay) & UKuroLevelStateMachineComponent.__PropertyMask_bStartOnBeginPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroLevelStateMachineComponent.__PropertyOffset_bStartOnBeginPlay) = ((*(base.NativePtr + (IntPtr)UKuroLevelStateMachineComponent.__PropertyOffset_bStartOnBeginPlay) & ~UKuroLevelStateMachineComponent.__PropertyMask_bStartOnBeginPlay) | (value ? UKuroLevelStateMachineComponent.__PropertyMask_bStartOnBeginPlay : 0));
			}
		}

		// Token: 0x170061C0 RID: 25024
		// (get) Token: 0x060187B1 RID: 100273 RVA: 0x002412F4 File Offset: 0x0023F4F4
		// (set) Token: 0x060187B2 RID: 100274 RVA: 0x0024132D File Offset: 0x0023F52D
		[Nullable(1)]
		public TArray<FKuroLevelStateLayer> Layers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroLevelStateLayer> result;
				if ((result = this._Layers) == null)
				{
					result = (this._Layers = new TArray<FKuroLevelStateLayer>(base.NativePtr + (IntPtr)UKuroLevelStateMachineComponent.__PropertyOffset_Layers, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Layers.CopyAssign(value);
			}
		}

		// Token: 0x170061C1 RID: 25025
		// (get) Token: 0x060187B3 RID: 100275 RVA: 0x0024133B File Offset: 0x0023F53B
		// (set) Token: 0x060187B4 RID: 100276 RVA: 0x0024134F File Offset: 0x0023F54F
		public unsafe ULevelSequencePlayer SequencePlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequencePlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelStateMachineComponent.__PropertyOffset_SequencePlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelStateMachineComponent.__PropertyOffset_SequencePlayer, value);
			}
		}

		// Token: 0x170061C2 RID: 25026
		// (get) Token: 0x060187B5 RID: 100277 RVA: 0x00241364 File Offset: 0x0023F564
		// (set) Token: 0x060187B6 RID: 100278 RVA: 0x00241378 File Offset: 0x0023F578
		public unsafe ALevelSequenceActor SequenceActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelStateMachineComponent.__PropertyOffset_SequenceActor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelStateMachineComponent.__PropertyOffset_SequenceActor, value);
			}
		}

		// Token: 0x060187B7 RID: 100279 RVA: 0x0024138D File Offset: 0x0023F58D
		public void Stop()
		{
			UKuroLevelStateMachineComponent.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x060187B8 RID: 100280 RVA: 0x0024139A File Offset: 0x0023F59A
		public void Start()
		{
			UKuroLevelStateMachineComponent.__Start_Internal(base.NativePtr);
		}

		// Token: 0x060187B9 RID: 100281 RVA: 0x002413A7 File Offset: 0x0023F5A7
		public void SetState(FName StateName, float PlayRate = 1f)
		{
			UKuroLevelStateMachineComponent.__SetState_Internal(base.NativePtr, StateName, PlayRate);
		}

		// Token: 0x060187BA RID: 100282 RVA: 0x002413B6 File Offset: 0x0023F5B6
		public bool HasState(FName StateName)
		{
			return UKuroLevelStateMachineComponent.__HasState_Internal(base.NativePtr, StateName);
		}

		// Token: 0x060187BB RID: 100283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x060187BC RID: 100284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Start_Internal(IntPtr @this);

		// Token: 0x060187BD RID: 100285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetState_Internal(IntPtr @this, FName StateName, float PlayRate);

		// Token: 0x060187BE RID: 100286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasState_Internal(IntPtr @this, FName StateName);

		// Token: 0x060187BF RID: 100287 RVA: 0x002413C4 File Offset: 0x0023F5C4
		static UKuroLevelStateMachineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroLevelStateMachine.KuroLevelStateMachineComponent");
		}

		// Token: 0x060187C0 RID: 100288 RVA: 0x002413D2 File Offset: 0x0023F5D2
		protected UKuroLevelStateMachineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D395 RID: 54165
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroLevelStateMachine.KuroLevelStateMachineComponent";

		// Token: 0x0400D396 RID: 54166
		private static IntPtr _ClassPtr;

		// Token: 0x0400D397 RID: 54167
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D398 RID: 54168
		internal static int __PropertyOffset_bStartOnBeginPlay;

		// Token: 0x0400D399 RID: 54169
		internal static byte __PropertyMask_bStartOnBeginPlay;

		// Token: 0x0400D39A RID: 54170
		internal static int __PropertyOffset_Layers;

		// Token: 0x0400D39B RID: 54171
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroLevelStateLayer> _Layers;

		// Token: 0x0400D39C RID: 54172
		internal static int __PropertyOffset_SequencePlayer;

		// Token: 0x0400D39D RID: 54173
		internal static int __PropertyOffset_SequenceActor;
	}
}
