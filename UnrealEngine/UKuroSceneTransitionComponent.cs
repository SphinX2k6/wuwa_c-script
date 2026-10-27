using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BAE RID: 7086
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSceneTransitionComponent")]
	[UnrealStructLayout(624, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 624)]
	public class UKuroSceneTransitionComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B1A2 RID: 111010 RVA: 0x0027EFCB File Offset: 0x0027D1CB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSceneTransitionComponent._ClassPtr;
		}

		// Token: 0x0601B1A3 RID: 111011 RVA: 0x0027EFD8 File Offset: 0x0027D1D8
		public UKuroSceneTransitionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSceneTransitionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B1A4 RID: 111012 RVA: 0x0027F000 File Offset: 0x0027D200
		public UKuroSceneTransitionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSceneTransitionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006CA2 RID: 27810
		// (get) Token: 0x0601B1A5 RID: 111013 RVA: 0x0027F034 File Offset: 0x0027D234
		// (set) Token: 0x0601B1A6 RID: 111014 RVA: 0x0027F06D File Offset: 0x0027D26D
		public TArray<int> TransitionIds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._TransitionIds) == null)
				{
					result = (this._TransitionIds = new TArray<int>(base.NativePtr + (IntPtr)UKuroSceneTransitionComponent.__PropertyOffset_TransitionIds, this));
				}
				return result;
			}
			set
			{
				this.TransitionIds.CopyAssign(value);
			}
		}

		// Token: 0x17006CA3 RID: 27811
		// (get) Token: 0x0601B1A7 RID: 111015 RVA: 0x0027F07B File Offset: 0x0027D27B
		// (set) Token: 0x0601B1A8 RID: 111016 RVA: 0x0027F08F File Offset: 0x0027D28F
		public unsafe FName TransitionCollection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSceneTransitionComponent.__PropertyOffset_TransitionCollection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneTransitionComponent.__PropertyOffset_TransitionCollection) = value;
			}
		}

		// Token: 0x17006CA4 RID: 27812
		// (get) Token: 0x0601B1A9 RID: 111017 RVA: 0x0027F0A4 File Offset: 0x0027D2A4
		// (set) Token: 0x0601B1AA RID: 111018 RVA: 0x0027F0B4 File Offset: 0x0027D2B4
		public unsafe EKuroSceneTransitionState State
		{
			get
			{
				return (EKuroSceneTransitionState)(*(base.NativePtr + (IntPtr)UKuroSceneTransitionComponent.__PropertyOffset_State));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSceneTransitionComponent.__PropertyOffset_State) = (byte)value;
			}
		}

		// Token: 0x0601B1AB RID: 111019 RVA: 0x0027F0C8 File Offset: 0x0027D2C8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void TickSceneTransition(float DeltaTime, float TransitionAge, float TransitionNormalizedProgress)
		{
			UKuroSceneTransitionComponent.__TickSceneTransition_FunctionParams* ptr = stackalloc UKuroSceneTransitionComponent.__TickSceneTransition_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroSceneTransitionComponent.__TickSceneTransition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroSceneTransitionComponent.__TickSceneTransition_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->TransitionAge = TransitionAge;
			ptr->TransitionNormalizedProgress = TransitionNormalizedProgress;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UKuroSceneTransitionComponent.__TickSceneTransition_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0601B1AC RID: 111020 RVA: 0x0027F11C File Offset: 0x0027D31C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ReregisterSceneTransitionComponent()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroSceneTransitionComponent.__ReregisterSceneTransitionComponent_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601B1AD RID: 111021 RVA: 0x0027F131 File Offset: 0x0027D331
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnSceneTransitionStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UKuroSceneTransitionComponent.__OnSceneTransitionStart_NativeFunctionPtr, null);
		}

		// Token: 0x0601B1AE RID: 111022 RVA: 0x0027F145 File Offset: 0x0027D345
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnSceneTransitionRegistered()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UKuroSceneTransitionComponent.__OnSceneTransitionRegistered_NativeFunctionPtr, null);
		}

		// Token: 0x0601B1AF RID: 111023 RVA: 0x0027F159 File Offset: 0x0027D359
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnSceneTransitionEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UKuroSceneTransitionComponent.__OnSceneTransitionEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0601B1B0 RID: 111024 RVA: 0x0027F16D File Offset: 0x0027D36D
		static UKuroSceneTransitionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneTransitionComponent");
		}

		// Token: 0x0601B1B1 RID: 111025 RVA: 0x0027F17B File Offset: 0x0027D37B
		protected UKuroSceneTransitionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E97C RID: 59772
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSceneTransitionComponent";

		// Token: 0x0400E97D RID: 59773
		private static IntPtr _ClassPtr;

		// Token: 0x0400E97E RID: 59774
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E97F RID: 59775
		internal static int __PropertyOffset_TransitionIds;

		// Token: 0x0400E980 RID: 59776
		[Nullable(2)]
		private TArray<int> _TransitionIds;

		// Token: 0x0400E981 RID: 59777
		internal static int __PropertyOffset_TransitionCollection;

		// Token: 0x0400E982 RID: 59778
		internal static int __PropertyOffset_State;

		// Token: 0x0400E983 RID: 59779
		private static IntPtr __TickSceneTransition_NativeFunctionPtr;

		// Token: 0x0400E984 RID: 59780
		private static IntPtr __ReregisterSceneTransitionComponent_NativeFunctionPtr;

		// Token: 0x0400E985 RID: 59781
		private static IntPtr __OnSceneTransitionStart_NativeFunctionPtr;

		// Token: 0x0400E986 RID: 59782
		private static IntPtr __OnSceneTransitionRegistered_NativeFunctionPtr;

		// Token: 0x0400E987 RID: 59783
		private static IntPtr __OnSceneTransitionEnd_NativeFunctionPtr;

		// Token: 0x02003177 RID: 12663
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __TickSceneTransition_FunctionParams
		{
			// Token: 0x04016FAA RID: 94122
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04016FAB RID: 94123
			[FieldOffset(4)]
			public float TransitionAge;

			// Token: 0x04016FAC RID: 94124
			[FieldOffset(8)]
			public float TransitionNormalizedProgress;
		}
	}
}
