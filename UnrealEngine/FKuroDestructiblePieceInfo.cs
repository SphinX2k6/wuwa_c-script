using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AE5 RID: 6885
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructiblePieceInfo")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroDestructiblePieceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019ADC RID: 105180 RVA: 0x0025F1B5 File Offset: 0x0025D3B5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroDestructiblePieceInfo._ScriptStructPtr != 0) ? FKuroDestructiblePieceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructiblePieceInfo", ref FKuroDestructiblePieceInfo._ScriptStructPtr);
		}

		// Token: 0x1700669E RID: 26270
		// (get) Token: 0x06019ADD RID: 105181 RVA: 0x0025F1D9 File Offset: 0x0025D3D9
		// (set) Token: 0x06019ADE RID: 105182 RVA: 0x0025F1ED File Offset: 0x0025D3ED
		[Nullable(2)]
		public unsafe UStaticMesh StaticMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroDestructiblePieceInfo.__PropertyOffset_StaticMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroDestructiblePieceInfo.__PropertyOffset_StaticMesh, value);
			}
		}

		// Token: 0x1700669F RID: 26271
		// (get) Token: 0x06019ADF RID: 105183 RVA: 0x0025F202 File Offset: 0x0025D402
		// (set) Token: 0x06019AE0 RID: 105184 RVA: 0x0025F216 File Offset: 0x0025D416
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructiblePieceInfo.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructiblePieceInfo.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x170066A0 RID: 26272
		// (get) Token: 0x06019AE1 RID: 105185 RVA: 0x0025F22B File Offset: 0x0025D42B
		// (set) Token: 0x06019AE2 RID: 105186 RVA: 0x0025F23F File Offset: 0x0025D43F
		public unsafe FName RelativeBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructiblePieceInfo.__PropertyOffset_RelativeBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructiblePieceInfo.__PropertyOffset_RelativeBoneName) = value;
			}
		}

		// Token: 0x06019AE3 RID: 105187 RVA: 0x0025F254 File Offset: 0x0025D454
		public FKuroDestructiblePieceInfo()
		{
		}

		// Token: 0x06019AE4 RID: 105188 RVA: 0x0025F25C File Offset: 0x0025D45C
		[NullableContext(1)]
		public FKuroDestructiblePieceInfo(UStaticMesh StaticMesh, FTransform InitialTransform, FName RelativeBoneName)
		{
			this.StaticMesh = StaticMesh;
			this.InitialTransform = InitialTransform;
			this.RelativeBoneName = RelativeBoneName;
		}

		// Token: 0x06019AE5 RID: 105189 RVA: 0x0025F279 File Offset: 0x0025D479
		protected override IntPtr GetUStructPtr()
		{
			return FKuroDestructiblePieceInfo.StaticStruct();
		}

		// Token: 0x06019AE6 RID: 105190 RVA: 0x0025F285 File Offset: 0x0025D485
		[NullableContext(2)]
		public FKuroDestructiblePieceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06019AE7 RID: 105191 RVA: 0x0025F28F File Offset: 0x0025D48F
		public FKuroDestructiblePieceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06019AE8 RID: 105192 RVA: 0x0025F29A File Offset: 0x0025D49A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroDestructiblePieceInfo(Pointer, false, true);
		}

		// Token: 0x06019AE9 RID: 105193 RVA: 0x0025F2A4 File Offset: 0x0025D4A4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroDestructiblePieceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400DF84 RID: 57220
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructiblePieceInfo";

		// Token: 0x0400DF85 RID: 57221
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DF86 RID: 57222
		internal static int __PropertyOffset_StaticMesh;

		// Token: 0x0400DF87 RID: 57223
		internal static int __PropertyOffset_InitialTransform;

		// Token: 0x0400DF88 RID: 57224
		internal static int __PropertyOffset_RelativeBoneName;
	}
}
