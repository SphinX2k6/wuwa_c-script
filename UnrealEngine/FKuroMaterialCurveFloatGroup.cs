using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B62 RID: 7010
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveFloatGroup")]
	[UnrealStructLayout(432, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 432)]
	public class FKuroMaterialCurveFloatGroup : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A89A RID: 108698 RVA: 0x0027212F File Offset: 0x0027032F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialCurveFloatGroup._ScriptStructPtr != 0) ? FKuroMaterialCurveFloatGroup._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveFloatGroup", ref FKuroMaterialCurveFloatGroup._ScriptStructPtr);
		}

		// Token: 0x17006AA9 RID: 27305
		// (get) Token: 0x0601A89B RID: 108699 RVA: 0x00272154 File Offset: 0x00270354
		// (set) Token: 0x0601A89C RID: 108700 RVA: 0x00272197 File Offset: 0x00270397
		public FKuroCurveFloat StartCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._StartCurve) == null)
				{
					result = (this._StartCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroMaterialCurveFloatGroup.__PropertyOffset_StartCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialCurveFloatGroup.__PropertyOffset_StartCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006AAA RID: 27306
		// (get) Token: 0x0601A89D RID: 108701 RVA: 0x002721B8 File Offset: 0x002703B8
		// (set) Token: 0x0601A89E RID: 108702 RVA: 0x002721FB File Offset: 0x002703FB
		public FKuroCurveFloat LoopCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._LoopCurve) == null)
				{
					result = (this._LoopCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroMaterialCurveFloatGroup.__PropertyOffset_LoopCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialCurveFloatGroup.__PropertyOffset_LoopCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006AAB RID: 27307
		// (get) Token: 0x0601A89F RID: 108703 RVA: 0x0027221C File Offset: 0x0027041C
		// (set) Token: 0x0601A8A0 RID: 108704 RVA: 0x0027225F File Offset: 0x0027045F
		public FKuroCurveFloat EndCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._EndCurve) == null)
				{
					result = (this._EndCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)FKuroMaterialCurveFloatGroup.__PropertyOffset_EndCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialCurveFloatGroup.__PropertyOffset_EndCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A8A1 RID: 108705 RVA: 0x00272280 File Offset: 0x00270480
		public FKuroMaterialCurveFloatGroup()
		{
		}

		// Token: 0x0601A8A2 RID: 108706 RVA: 0x00272288 File Offset: 0x00270488
		public FKuroMaterialCurveFloatGroup(FKuroCurveFloat StartCurve, FKuroCurveFloat LoopCurve, FKuroCurveFloat EndCurve)
		{
			this.StartCurve = StartCurve;
			this.LoopCurve = LoopCurve;
			this.EndCurve = EndCurve;
		}

		// Token: 0x0601A8A3 RID: 108707 RVA: 0x002722A5 File Offset: 0x002704A5
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialCurveFloatGroup.StaticStruct();
		}

		// Token: 0x0601A8A4 RID: 108708 RVA: 0x002722B1 File Offset: 0x002704B1
		[NullableContext(2)]
		public FKuroMaterialCurveFloatGroup(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A8A5 RID: 108709 RVA: 0x002722BB File Offset: 0x002704BB
		public FKuroMaterialCurveFloatGroup(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A8A6 RID: 108710 RVA: 0x002722C6 File Offset: 0x002704C6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialCurveFloatGroup(Pointer, false, true);
		}

		// Token: 0x0601A8A7 RID: 108711 RVA: 0x002722D0 File Offset: 0x002704D0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialCurveFloatGroup(Pointer, MemoryOwner);
		}

		// Token: 0x0400E5F2 RID: 58866
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialCurveFloatGroup";

		// Token: 0x0400E5F3 RID: 58867
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E5F4 RID: 58868
		internal static int __PropertyOffset_StartCurve;

		// Token: 0x0400E5F5 RID: 58869
		[Nullable(2)]
		private FKuroCurveFloat _StartCurve;

		// Token: 0x0400E5F6 RID: 58870
		internal static int __PropertyOffset_LoopCurve;

		// Token: 0x0400E5F7 RID: 58871
		[Nullable(2)]
		private FKuroCurveFloat _LoopCurve;

		// Token: 0x0400E5F8 RID: 58872
		internal static int __PropertyOffset_EndCurve;

		// Token: 0x0400E5F9 RID: 58873
		[Nullable(2)]
		private FKuroCurveFloat _EndCurve;
	}
}
