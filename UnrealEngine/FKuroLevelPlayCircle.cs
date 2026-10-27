using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020018E4 RID: 6372
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayCircle")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroLevelPlayCircle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060179F1 RID: 96753 RVA: 0x00229E01 File Offset: 0x00228001
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLevelPlayCircle._ScriptStructPtr != 0) ? FKuroLevelPlayCircle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroLevelPlayCircle", ref FKuroLevelPlayCircle._ScriptStructPtr);
		}

		// Token: 0x17005F2E RID: 24366
		// (get) Token: 0x060179F2 RID: 96754 RVA: 0x00229E25 File Offset: 0x00228025
		// (set) Token: 0x060179F3 RID: 96755 RVA: 0x00229E39 File Offset: 0x00228039
		public unsafe FVectorDouble Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayCircle.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayCircle.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17005F2F RID: 24367
		// (get) Token: 0x060179F4 RID: 96756 RVA: 0x00229E4E File Offset: 0x0022804E
		// (set) Token: 0x060179F5 RID: 96757 RVA: 0x00229E5E File Offset: 0x0022805E
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLevelPlayCircle.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLevelPlayCircle.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x060179F6 RID: 96758 RVA: 0x00229E6F File Offset: 0x0022806F
		public FKuroLevelPlayCircle()
		{
		}

		// Token: 0x060179F7 RID: 96759 RVA: 0x00229E77 File Offset: 0x00228077
		public FKuroLevelPlayCircle(FVectorDouble Position, float Radius)
		{
			this.Position = Position;
			this.Radius = Radius;
		}

		// Token: 0x060179F8 RID: 96760 RVA: 0x00229E8D File Offset: 0x0022808D
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLevelPlayCircle.StaticStruct();
		}

		// Token: 0x060179F9 RID: 96761 RVA: 0x00229E99 File Offset: 0x00228099
		[NullableContext(2)]
		public FKuroLevelPlayCircle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060179FA RID: 96762 RVA: 0x00229EA3 File Offset: 0x002280A3
		public FKuroLevelPlayCircle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060179FB RID: 96763 RVA: 0x00229EAE File Offset: 0x002280AE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLevelPlayCircle(Pointer, false, true);
		}

		// Token: 0x060179FC RID: 96764 RVA: 0x00229EB8 File Offset: 0x002280B8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLevelPlayCircle(Pointer, MemoryOwner);
		}

		// Token: 0x0400CD49 RID: 52553
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayCircle";

		// Token: 0x0400CD4A RID: 52554
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CD4B RID: 52555
		internal static int __PropertyOffset_Position;

		// Token: 0x0400CD4C RID: 52556
		internal static int __PropertyOffset_Radius;
	}
}
