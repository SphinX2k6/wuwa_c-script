using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012C5 RID: 4805
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Foliage.FoliageDensityFalloff")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FFoliageDensityFalloff : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011944 RID: 72004 RVA: 0x0019C948 File Offset: 0x0019AB48
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFoliageDensityFalloff._ScriptStructPtr != 0) ? FFoliageDensityFalloff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Foliage.FoliageDensityFalloff", ref FFoliageDensityFalloff._ScriptStructPtr);
		}

		// Token: 0x17004492 RID: 17554
		// (get) Token: 0x06011945 RID: 72005 RVA: 0x0019C96C File Offset: 0x0019AB6C
		// (set) Token: 0x06011946 RID: 72006 RVA: 0x0019C97C File Offset: 0x0019AB7C
		public unsafe bool bUseFalloffCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoliageDensityFalloff.__PropertyOffset_bUseFalloffCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoliageDensityFalloff.__PropertyOffset_bUseFalloffCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004493 RID: 17555
		// (get) Token: 0x06011947 RID: 72007 RVA: 0x0019C990 File Offset: 0x0019AB90
		// (set) Token: 0x06011948 RID: 72008 RVA: 0x0019C9D3 File Offset: 0x0019ABD3
		public FRuntimeFloatCurve FalloffCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._FalloffCurve) == null)
				{
					result = (this._FalloffCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FFoliageDensityFalloff.__PropertyOffset_FalloffCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FFoliageDensityFalloff.__PropertyOffset_FalloffCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06011949 RID: 72009 RVA: 0x0019C9F4 File Offset: 0x0019ABF4
		public FFoliageDensityFalloff()
		{
		}

		// Token: 0x0601194A RID: 72010 RVA: 0x0019C9FC File Offset: 0x0019ABFC
		public FFoliageDensityFalloff(bool bUseFalloffCurve, FRuntimeFloatCurve FalloffCurve)
		{
			this.bUseFalloffCurve = bUseFalloffCurve;
			this.FalloffCurve = FalloffCurve;
		}

		// Token: 0x0601194B RID: 72011 RVA: 0x0019CA12 File Offset: 0x0019AC12
		protected override IntPtr GetUStructPtr()
		{
			return FFoliageDensityFalloff.StaticStruct();
		}

		// Token: 0x0601194C RID: 72012 RVA: 0x0019CA1E File Offset: 0x0019AC1E
		[NullableContext(2)]
		public FFoliageDensityFalloff(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601194D RID: 72013 RVA: 0x0019CA28 File Offset: 0x0019AC28
		public FFoliageDensityFalloff(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601194E RID: 72014 RVA: 0x0019CA33 File Offset: 0x0019AC33
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFoliageDensityFalloff(Pointer, false, true);
		}

		// Token: 0x0601194F RID: 72015 RVA: 0x0019CA3D File Offset: 0x0019AC3D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFoliageDensityFalloff(Pointer, MemoryOwner);
		}

		// Token: 0x040096AD RID: 38573
		public const string __ObjectPath = "/Script/Foliage.FoliageDensityFalloff";

		// Token: 0x040096AE RID: 38574
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040096AF RID: 38575
		internal static int __PropertyOffset_bUseFalloffCurve;

		// Token: 0x040096B0 RID: 38576
		internal static int __PropertyOffset_FalloffCurve;

		// Token: 0x040096B1 RID: 38577
		[Nullable(2)]
		private FRuntimeFloatCurve _FalloffCurve;
	}
}
