using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010A0 RID: 4256
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RootMotionSourceGroup")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRootMotionSourceGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F348 RID: 62280 RVA: 0x00168CC8 File Offset: 0x00166EC8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionSourceGroup._ScriptStructPtr != 0) ? FRootMotionSourceGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionSourceGroup", ref FRootMotionSourceGroup._ScriptStructPtr);
		}

		// Token: 0x17003B42 RID: 15170
		// (get) Token: 0x0600F349 RID: 62281 RVA: 0x00168CEC File Offset: 0x00166EEC
		// (set) Token: 0x0600F34A RID: 62282 RVA: 0x00168D05 File Offset: 0x00166F05
		public unsafe bool bHasAdditiveSources
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bHasAdditiveSources) & FRootMotionSourceGroup.__PropertyMask_bHasAdditiveSources) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bHasAdditiveSources) = ((*(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bHasAdditiveSources) & ~FRootMotionSourceGroup.__PropertyMask_bHasAdditiveSources) | (value ? FRootMotionSourceGroup.__PropertyMask_bHasAdditiveSources : 0));
			}
		}

		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x0600F34B RID: 62283 RVA: 0x00168D35 File Offset: 0x00166F35
		// (set) Token: 0x0600F34C RID: 62284 RVA: 0x00168D4E File Offset: 0x00166F4E
		public unsafe bool bHasOverrideSources
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bHasOverrideSources) & FRootMotionSourceGroup.__PropertyMask_bHasOverrideSources) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bHasOverrideSources) = ((*(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bHasOverrideSources) & ~FRootMotionSourceGroup.__PropertyMask_bHasOverrideSources) | (value ? FRootMotionSourceGroup.__PropertyMask_bHasOverrideSources : 0));
			}
		}

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x0600F34D RID: 62285 RVA: 0x00168D7E File Offset: 0x00166F7E
		// (set) Token: 0x0600F34E RID: 62286 RVA: 0x00168D97 File Offset: 0x00166F97
		public unsafe bool bHasOverrideSourcesWithIgnoreZAccumulate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bHasOverrideSourcesWithIgnoreZAccumulate) & FRootMotionSourceGroup.__PropertyMask_bHasOverrideSourcesWithIgnoreZAccumulate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bHasOverrideSourcesWithIgnoreZAccumulate) = ((*(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bHasOverrideSourcesWithIgnoreZAccumulate) & ~FRootMotionSourceGroup.__PropertyMask_bHasOverrideSourcesWithIgnoreZAccumulate) | (value ? FRootMotionSourceGroup.__PropertyMask_bHasOverrideSourcesWithIgnoreZAccumulate : 0));
			}
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x0600F34F RID: 62287 RVA: 0x00168DC7 File Offset: 0x00166FC7
		// (set) Token: 0x0600F350 RID: 62288 RVA: 0x00168DE0 File Offset: 0x00166FE0
		public unsafe bool bIsAdditiveVelocityApplied
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bIsAdditiveVelocityApplied) & FRootMotionSourceGroup.__PropertyMask_bIsAdditiveVelocityApplied) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bIsAdditiveVelocityApplied) = ((*(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_bIsAdditiveVelocityApplied) & ~FRootMotionSourceGroup.__PropertyMask_bIsAdditiveVelocityApplied) | (value ? FRootMotionSourceGroup.__PropertyMask_bIsAdditiveVelocityApplied : 0));
			}
		}

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x0600F351 RID: 62289 RVA: 0x00168E10 File Offset: 0x00167010
		// (set) Token: 0x0600F352 RID: 62290 RVA: 0x00168E53 File Offset: 0x00167053
		public FRootMotionSourceSettings LastAccumulatedSettings
		{
			get
			{
				base.FastCheckIsValid();
				FRootMotionSourceSettings result;
				if ((result = this._LastAccumulatedSettings) == null)
				{
					result = (this._LastAccumulatedSettings = new FRootMotionSourceSettings(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_LastAccumulatedSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionSourceSettings.StaticStruct(), base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_LastAccumulatedSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x0600F353 RID: 62291 RVA: 0x00168E74 File Offset: 0x00167074
		// (set) Token: 0x0600F354 RID: 62292 RVA: 0x00168E88 File Offset: 0x00167088
		public unsafe FVector_NetQuantize10 LastPreAdditiveVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_LastPreAdditiveVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionSourceGroup.__PropertyOffset_LastPreAdditiveVelocity) = value;
			}
		}

		// Token: 0x0600F355 RID: 62293 RVA: 0x00168E9D File Offset: 0x0016709D
		public FRootMotionSourceGroup()
		{
		}

		// Token: 0x0600F356 RID: 62294 RVA: 0x00168EA5 File Offset: 0x001670A5
		public FRootMotionSourceGroup(bool bHasAdditiveSources, bool bHasOverrideSources, bool bHasOverrideSourcesWithIgnoreZAccumulate, bool bIsAdditiveVelocityApplied, FRootMotionSourceSettings LastAccumulatedSettings, FVector_NetQuantize10 LastPreAdditiveVelocity)
		{
			this.bHasAdditiveSources = bHasAdditiveSources;
			this.bHasOverrideSources = bHasOverrideSources;
			this.bHasOverrideSourcesWithIgnoreZAccumulate = bHasOverrideSourcesWithIgnoreZAccumulate;
			this.bIsAdditiveVelocityApplied = bIsAdditiveVelocityApplied;
			this.LastAccumulatedSettings = LastAccumulatedSettings;
			this.LastPreAdditiveVelocity = LastPreAdditiveVelocity;
		}

		// Token: 0x0600F357 RID: 62295 RVA: 0x00168EDA File Offset: 0x001670DA
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionSourceGroup.StaticStruct();
		}

		// Token: 0x0600F358 RID: 62296 RVA: 0x00168EE6 File Offset: 0x001670E6
		[NullableContext(2)]
		public FRootMotionSourceGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F359 RID: 62297 RVA: 0x00168EF0 File Offset: 0x001670F0
		public FRootMotionSourceGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F35A RID: 62298 RVA: 0x00168EFB File Offset: 0x001670FB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionSourceGroup(Pointer, false, true);
		}

		// Token: 0x0600F35B RID: 62299 RVA: 0x00168F05 File Offset: 0x00167105
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionSourceGroup(Pointer, MemoryOwner);
		}

		// Token: 0x040083ED RID: 33773
		public const string __ObjectPath = "/Script/Engine.RootMotionSourceGroup";

		// Token: 0x040083EE RID: 33774
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083EF RID: 33775
		internal static int __PropertyOffset_bHasAdditiveSources;

		// Token: 0x040083F0 RID: 33776
		internal static byte __PropertyMask_bHasAdditiveSources;

		// Token: 0x040083F1 RID: 33777
		internal static int __PropertyOffset_bHasOverrideSources;

		// Token: 0x040083F2 RID: 33778
		internal static byte __PropertyMask_bHasOverrideSources;

		// Token: 0x040083F3 RID: 33779
		internal static int __PropertyOffset_bHasOverrideSourcesWithIgnoreZAccumulate;

		// Token: 0x040083F4 RID: 33780
		internal static byte __PropertyMask_bHasOverrideSourcesWithIgnoreZAccumulate;

		// Token: 0x040083F5 RID: 33781
		internal static int __PropertyOffset_bIsAdditiveVelocityApplied;

		// Token: 0x040083F6 RID: 33782
		internal static byte __PropertyMask_bIsAdditiveVelocityApplied;

		// Token: 0x040083F7 RID: 33783
		internal static int __PropertyOffset_LastAccumulatedSettings;

		// Token: 0x040083F8 RID: 33784
		[Nullable(2)]
		private FRootMotionSourceSettings _LastAccumulatedSettings;

		// Token: 0x040083F9 RID: 33785
		internal static int __PropertyOffset_LastPreAdditiveVelocity;
	}
}
