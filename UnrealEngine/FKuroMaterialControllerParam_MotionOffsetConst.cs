using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B48 RID: 6984
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MotionOffsetConst")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FKuroMaterialControllerParam_MotionOffsetConst : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A719 RID: 108313 RVA: 0x0026FC95 File Offset: 0x0026DE95
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialControllerParam_MotionOffsetConst._ScriptStructPtr != 0) ? FKuroMaterialControllerParam_MotionOffsetConst._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MotionOffsetConst", ref FKuroMaterialControllerParam_MotionOffsetConst._ScriptStructPtr);
		}

		// Token: 0x17006A50 RID: 27216
		// (get) Token: 0x0601A71A RID: 108314 RVA: 0x0026FCB9 File Offset: 0x0026DEB9
		// (set) Token: 0x0601A71B RID: 108315 RVA: 0x0026FCC9 File Offset: 0x0026DEC9
		public unsafe float MotionAffectVertexRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffsetConst.__PropertyOffset_MotionAffectVertexRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffsetConst.__PropertyOffset_MotionAffectVertexRange) = value;
			}
		}

		// Token: 0x17006A51 RID: 27217
		// (get) Token: 0x0601A71C RID: 108316 RVA: 0x0026FCDA File Offset: 0x0026DEDA
		// (set) Token: 0x0601A71D RID: 108317 RVA: 0x0026FCEA File Offset: 0x0026DEEA
		public unsafe float MotionOffsetLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffsetConst.__PropertyOffset_MotionOffsetLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffsetConst.__PropertyOffset_MotionOffsetLength) = value;
			}
		}

		// Token: 0x17006A52 RID: 27218
		// (get) Token: 0x0601A71E RID: 108318 RVA: 0x0026FCFB File Offset: 0x0026DEFB
		// (set) Token: 0x0601A71F RID: 108319 RVA: 0x0026FD0B File Offset: 0x0026DF0B
		public unsafe float MotionNoiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffsetConst.__PropertyOffset_MotionNoiseSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialControllerParam_MotionOffsetConst.__PropertyOffset_MotionNoiseSpeed) = value;
			}
		}

		// Token: 0x0601A720 RID: 108320 RVA: 0x0026FD1C File Offset: 0x0026DF1C
		public FKuroMaterialControllerParam_MotionOffsetConst()
		{
		}

		// Token: 0x0601A721 RID: 108321 RVA: 0x0026FD24 File Offset: 0x0026DF24
		public FKuroMaterialControllerParam_MotionOffsetConst(float MotionAffectVertexRange, float MotionOffsetLength, float MotionNoiseSpeed)
		{
			this.MotionAffectVertexRange = MotionAffectVertexRange;
			this.MotionOffsetLength = MotionOffsetLength;
			this.MotionNoiseSpeed = MotionNoiseSpeed;
		}

		// Token: 0x0601A722 RID: 108322 RVA: 0x0026FD41 File Offset: 0x0026DF41
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialControllerParam_MotionOffsetConst.StaticStruct();
		}

		// Token: 0x0601A723 RID: 108323 RVA: 0x0026FD4D File Offset: 0x0026DF4D
		[NullableContext(2)]
		public FKuroMaterialControllerParam_MotionOffsetConst(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A724 RID: 108324 RVA: 0x0026FD57 File Offset: 0x0026DF57
		public FKuroMaterialControllerParam_MotionOffsetConst(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A725 RID: 108325 RVA: 0x0026FD62 File Offset: 0x0026DF62
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialControllerParam_MotionOffsetConst(Pointer, false, true);
		}

		// Token: 0x0601A726 RID: 108326 RVA: 0x0026FD6C File Offset: 0x0026DF6C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialControllerParam_MotionOffsetConst(Pointer, MemoryOwner);
		}

		// Token: 0x0400E53D RID: 58685
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialControllerParam_MotionOffsetConst";

		// Token: 0x0400E53E RID: 58686
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E53F RID: 58687
		internal static int __PropertyOffset_MotionAffectVertexRange;

		// Token: 0x0400E540 RID: 58688
		internal static int __PropertyOffset_MotionOffsetLength;

		// Token: 0x0400E541 RID: 58689
		internal static int __PropertyOffset_MotionNoiseSpeed;
	}
}
