using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000357 RID: 855
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiAnimSequenceConfig")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroCrowdAiAnimSequenceConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005744 RID: 22340 RVA: 0x0007AEC3 File Offset: 0x000790C3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCrowdAiAnimSequenceConfig._ScriptStructPtr != 0) ? FKuroCrowdAiAnimSequenceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCrowdAi.KuroCrowdAiAnimSequenceConfig", ref FKuroCrowdAiAnimSequenceConfig._ScriptStructPtr);
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x06005745 RID: 22341 RVA: 0x0007AEE7 File Offset: 0x000790E7
		// (set) Token: 0x06005746 RID: 22342 RVA: 0x0007AEF7 File Offset: 0x000790F7
		public unsafe int AnimIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCrowdAiAnimSequenceConfig.__PropertyOffset_AnimIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimSequenceConfig.__PropertyOffset_AnimIndex) = value;
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06005747 RID: 22343 RVA: 0x0007AF08 File Offset: 0x00079108
		// (set) Token: 0x06005748 RID: 22344 RVA: 0x0007AF18 File Offset: 0x00079118
		public unsafe float BlendInTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCrowdAiAnimSequenceConfig.__PropertyOffset_BlendInTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCrowdAiAnimSequenceConfig.__PropertyOffset_BlendInTime) = value;
			}
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x0007AF29 File Offset: 0x00079129
		public FKuroCrowdAiAnimSequenceConfig()
		{
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x0007AF31 File Offset: 0x00079131
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCrowdAiAnimSequenceConfig.StaticStruct();
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x0007AF3D File Offset: 0x0007913D
		[NullableContext(2)]
		public FKuroCrowdAiAnimSequenceConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600574C RID: 22348 RVA: 0x0007AF47 File Offset: 0x00079147
		public FKuroCrowdAiAnimSequenceConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600574D RID: 22349 RVA: 0x0007AF52 File Offset: 0x00079152
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCrowdAiAnimSequenceConfig(Pointer, false, true);
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x0007AF5C File Offset: 0x0007915C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCrowdAiAnimSequenceConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040023F2 RID: 9202
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiAnimSequenceConfig";

		// Token: 0x040023F3 RID: 9203
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023F4 RID: 9204
		internal static int __PropertyOffset_AnimIndex;

		// Token: 0x040023F5 RID: 9205
		internal static int __PropertyOffset_BlendInTime;
	}
}
