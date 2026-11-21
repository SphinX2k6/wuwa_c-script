using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004C2 RID: 1218
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleEffect")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FKuroDestructibleEffect : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007064 RID: 28772 RVA: 0x000A60F1 File Offset: 0x000A42F1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroDestructibleEffect._ScriptStructPtr != 0) ? FKuroDestructibleEffect._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleEffect", ref FKuroDestructibleEffect._ScriptStructPtr);
		}

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x06007065 RID: 28773 RVA: 0x000A6115 File Offset: 0x000A4315
		// (set) Token: 0x06007066 RID: 28774 RVA: 0x000A6129 File Offset: 0x000A4329
		public unsafe FName EffectModelPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_EffectModelPath);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_EffectModelPath) = value;
			}
		}

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x06007067 RID: 28775 RVA: 0x000A613E File Offset: 0x000A433E
		// (set) Token: 0x06007068 RID: 28776 RVA: 0x000A6152 File Offset: 0x000A4352
		public unsafe FTransform Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x06007069 RID: 28777 RVA: 0x000A6167 File Offset: 0x000A4367
		// (set) Token: 0x0600706A RID: 28778 RVA: 0x000A617B File Offset: 0x000A437B
		public unsafe FName Socket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_Socket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_Socket) = value;
			}
		}

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x0600706B RID: 28779 RVA: 0x000A6190 File Offset: 0x000A4390
		// (set) Token: 0x0600706C RID: 28780 RVA: 0x000A61A0 File Offset: 0x000A43A0
		public unsafe bool AttachLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachLocation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachLocation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x0600706D RID: 28781 RVA: 0x000A61B1 File Offset: 0x000A43B1
		// (set) Token: 0x0600706E RID: 28782 RVA: 0x000A61C1 File Offset: 0x000A43C1
		public unsafe bool AttachRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x0600706F RID: 28783 RVA: 0x000A61D2 File Offset: 0x000A43D2
		// (set) Token: 0x06007070 RID: 28784 RVA: 0x000A61E2 File Offset: 0x000A43E2
		public unsafe bool AttachScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_AttachScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x06007071 RID: 28785 RVA: 0x000A61F3 File Offset: 0x000A43F3
		// (set) Token: 0x06007072 RID: 28786 RVA: 0x000A6203 File Offset: 0x000A4403
		public unsafe bool DetachOnEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_DetachOnEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDestructibleEffect.__PropertyOffset_DetachOnEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007073 RID: 28787 RVA: 0x000A6214 File Offset: 0x000A4414
		public FKuroDestructibleEffect()
		{
		}

		// Token: 0x06007074 RID: 28788 RVA: 0x000A621C File Offset: 0x000A441C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroDestructibleEffect.StaticStruct();
		}

		// Token: 0x06007075 RID: 28789 RVA: 0x000A6228 File Offset: 0x000A4428
		[NullableContext(2)]
		public FKuroDestructibleEffect(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x000A6232 File Offset: 0x000A4432
		public FKuroDestructibleEffect(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007077 RID: 28791 RVA: 0x000A623D File Offset: 0x000A443D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroDestructibleEffect(Pointer, false, true);
		}

		// Token: 0x06007078 RID: 28792 RVA: 0x000A6247 File Offset: 0x000A4447
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroDestructibleEffect(Pointer, MemoryOwner);
		}

		// Token: 0x04003093 RID: 12435
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleEffect";

		// Token: 0x04003094 RID: 12436
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003095 RID: 12437
		internal static int __PropertyOffset_EffectModelPath;

		// Token: 0x04003096 RID: 12438
		internal static int __PropertyOffset_Offset;

		// Token: 0x04003097 RID: 12439
		internal static int __PropertyOffset_Socket;

		// Token: 0x04003098 RID: 12440
		internal static int __PropertyOffset_AttachLocation;

		// Token: 0x04003099 RID: 12441
		internal static int __PropertyOffset_AttachRotation;

		// Token: 0x0400309A RID: 12442
		internal static int __PropertyOffset_AttachScale;

		// Token: 0x0400309B RID: 12443
		internal static int __PropertyOffset_DetachOnEnd;
	}
}
