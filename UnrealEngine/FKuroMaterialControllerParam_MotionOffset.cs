using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B47 RID: 6983
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MotionOffset")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 440)]
	public class FKuroMaterialControllerParam_MotionOffset : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A70B RID: 108299 RVA: 0x0026FB72 File Offset: 0x0026DD72
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_MotionOffset._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_MotionOffset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MotionOffset", ref FKuroMaterialControllerParam_MotionOffset._ScriptStructPtr);
		}

		// Token: 0x17006A4D RID: 27213
		// (get) Token: 0x0601A70C RID: 108300 RVA: 0x0026FB96 File Offset: 0x0026DD96
		// (set) Token: 0x0601A70D RID: 108301 RVA: 0x0026FBA6 File Offset: 0x0026DDA6
		public unsafe float MotionAffectVertexRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffset.__PropertyOffset_MotionAffectVertexRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffset.__PropertyOffset_MotionAffectVertexRange) = value;
			}
		}

		// Token: 0x17006A4E RID: 27214
		// (get) Token: 0x0601A70E RID: 108302 RVA: 0x0026FBB7 File Offset: 0x0026DDB7
		// (set) Token: 0x0601A70F RID: 108303 RVA: 0x0026FBC7 File Offset: 0x0026DDC7
		public unsafe float MotionOffsetLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffset.__PropertyOffset_MotionOffsetLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffset.__PropertyOffset_MotionOffsetLength) = value;
			}
		}

		// Token: 0x17006A4F RID: 27215
		// (get) Token: 0x0601A710 RID: 108304 RVA: 0x0026FBD8 File Offset: 0x0026DDD8
		// (set) Token: 0x0601A711 RID: 108305 RVA: 0x0026FC1B File Offset: 0x0026DE1B
		public FKuroMaterialCurveFloatGroup MotionNoiseSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroMaterialCurveFloatGroup result;
				if ((result = this._MotionNoiseSpeed) == null)
				{
					result = (this._MotionNoiseSpeed = new FKuroMaterialCurveFloatGroup(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffset.__PropertyOffset_MotionNoiseSpeed, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMaterialCurveFloatGroup.StaticStruct(), base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffset.__PropertyOffset_MotionNoiseSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0601A712 RID: 108306 RVA: 0x0026FC3C File Offset: 0x0026DE3C
		public FKuroMaterialControllerParam_MotionOffset()
		{
		}

		// Token: 0x0601A713 RID: 108307 RVA: 0x0026FC44 File Offset: 0x0026DE44
		public FKuroMaterialControllerParam_MotionOffset(float MotionAffectVertexRange, float MotionOffsetLength, FKuroMaterialCurveFloatGroup MotionNoiseSpeed)
		{
			this.MotionAffectVertexRange = MotionAffectVertexRange;
			this.MotionOffsetLength = MotionOffsetLength;
			this.MotionNoiseSpeed = MotionNoiseSpeed;
		}

		// Token: 0x0601A714 RID: 108308 RVA: 0x0026FC61 File Offset: 0x0026DE61
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_MotionOffset.StaticStruct();
		}

		// Token: 0x0601A715 RID: 108309 RVA: 0x0026FC6D File Offset: 0x0026DE6D
		[NullableContext(2)]
		public FKuroMaterialControllerParam_MotionOffset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A716 RID: 108310 RVA: 0x0026FC77 File Offset: 0x0026DE77
		public FKuroMaterialControllerParam_MotionOffset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A717 RID: 108311 RVA: 0x0026FC82 File Offset: 0x0026DE82
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_MotionOffset(Pointer, false, true);
		}

		// Token: 0x0601A718 RID: 108312 RVA: 0x0026FC8C File Offset: 0x0026DE8C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_MotionOffset(Pointer, MemoryOwner);
		}

		// Token: 0x0400E537 RID: 58679
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MotionOffset";

		// Token: 0x0400E538 RID: 58680
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E539 RID: 58681
		internal static int __PropertyOffset_MotionAffectVertexRange;

		// Token: 0x0400E53A RID: 58682
		internal static int __PropertyOffset_MotionOffsetLength;

		// Token: 0x0400E53B RID: 58683
		internal static int __PropertyOffset_MotionNoiseSpeed;

		// Token: 0x0400E53C RID: 58684
		[Nullable(2)]
		private FKuroMaterialCurveFloatGroup _MotionNoiseSpeed;
	}
}
