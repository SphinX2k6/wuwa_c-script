using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002BC RID: 700
	[UnrealObjectPath("/Script/AnimationCore.ConstraintOffset")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FConstraintOffset : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060026FA RID: 9978 RVA: 0x0003A91F File Offset: 0x00038B1F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintOffset._ScriptStructPtr != 0) ? FConstraintOffset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.ConstraintOffset", ref FConstraintOffset._ScriptStructPtr);
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x0003A943 File Offset: 0x00038B43
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x0003A957 File Offset: 0x00038B57
		public unsafe FVector Translation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintOffset.__PropertyOffset_Translation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintOffset.__PropertyOffset_Translation) = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x0003A96C File Offset: 0x00038B6C
		// (set) Token: 0x060026FE RID: 9982 RVA: 0x0003A980 File Offset: 0x00038B80
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintOffset.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintOffset.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x0003A995 File Offset: 0x00038B95
		// (set) Token: 0x06002700 RID: 9984 RVA: 0x0003A9A9 File Offset: 0x00038BA9
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintOffset.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintOffset.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x0003A9BE File Offset: 0x00038BBE
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x0003A9D2 File Offset: 0x00038BD2
		public unsafe FTransform Parent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintOffset.__PropertyOffset_Parent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintOffset.__PropertyOffset_Parent) = value;
			}
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x0003A9E7 File Offset: 0x00038BE7
		public FConstraintOffset()
		{
		}

		// Token: 0x06002704 RID: 9988 RVA: 0x0003A9EF File Offset: 0x00038BEF
		public FConstraintOffset(FVector Translation, FQuat Rotation, FVector Scale, FTransform Parent)
		{
			this.Translation = Translation;
			this.Rotation = Rotation;
			this.Scale = Scale;
			this.Parent = Parent;
		}

		// Token: 0x06002705 RID: 9989 RVA: 0x0003AA14 File Offset: 0x00038C14
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintOffset.StaticStruct();
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x0003AA20 File Offset: 0x00038C20
		[NullableContext(2)]
		public FConstraintOffset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002707 RID: 9991 RVA: 0x0003AA2A File Offset: 0x00038C2A
		public FConstraintOffset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002708 RID: 9992 RVA: 0x0003AA35 File Offset: 0x00038C35
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintOffset(Pointer, false, true);
		}

		// Token: 0x06002709 RID: 9993 RVA: 0x0003AA3F File Offset: 0x00038C3F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintOffset(Pointer, MemoryOwner);
		}

		// Token: 0x04000F53 RID: 3923
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimationCore.ConstraintOffset";

		// Token: 0x04000F54 RID: 3924
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F55 RID: 3925
		internal static int __PropertyOffset_Translation;

		// Token: 0x04000F56 RID: 3926
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04000F57 RID: 3927
		internal static int __PropertyOffset_Scale;

		// Token: 0x04000F58 RID: 3928
		internal static int __PropertyOffset_Parent;
	}
}
