using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001027 RID: 4135
	[UnrealObjectPath("/Script/Engine.POV")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FPOV : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E8B6 RID: 59574 RVA: 0x00159BBA File Offset: 0x00157DBA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPOV._ScriptStructPtr != 0) ? FPOV._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.POV", ref FPOV._ScriptStructPtr);
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600E8B7 RID: 59575 RVA: 0x00159BDE File Offset: 0x00157DDE
		// (set) Token: 0x0600E8B8 RID: 59576 RVA: 0x00159BF2 File Offset: 0x00157DF2
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOV.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOV.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600E8B9 RID: 59577 RVA: 0x00159C07 File Offset: 0x00157E07
		// (set) Token: 0x0600E8BA RID: 59578 RVA: 0x00159C1B File Offset: 0x00157E1B
		public unsafe FRotator Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOV.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOV.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0600E8BB RID: 59579 RVA: 0x00159C30 File Offset: 0x00157E30
		// (set) Token: 0x0600E8BC RID: 59580 RVA: 0x00159C40 File Offset: 0x00157E40
		public unsafe float FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPOV.__PropertyOffset_FOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPOV.__PropertyOffset_FOV) = value;
			}
		}

		// Token: 0x0600E8BD RID: 59581 RVA: 0x00159C51 File Offset: 0x00157E51
		public FPOV()
		{
		}

		// Token: 0x0600E8BE RID: 59582 RVA: 0x00159C59 File Offset: 0x00157E59
		public FPOV(FVector Location, FRotator Rotation, float FOV)
		{
			this.Location = Location;
			this.Rotation = Rotation;
			this.FOV = FOV;
		}

		// Token: 0x0600E8BF RID: 59583 RVA: 0x00159C76 File Offset: 0x00157E76
		protected override IntPtr GetUStructPtr()
		{
			return FPOV.StaticStruct();
		}

		// Token: 0x0600E8C0 RID: 59584 RVA: 0x00159C82 File Offset: 0x00157E82
		[NullableContext(2)]
		public FPOV(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E8C1 RID: 59585 RVA: 0x00159C8C File Offset: 0x00157E8C
		public FPOV(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E8C2 RID: 59586 RVA: 0x00159C97 File Offset: 0x00157E97
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPOV(Pointer, false, true);
		}

		// Token: 0x0600E8C3 RID: 59587 RVA: 0x00159CA1 File Offset: 0x00157EA1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPOV(Pointer, MemoryOwner);
		}

		// Token: 0x04007E5C RID: 32348
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.POV";

		// Token: 0x04007E5D RID: 32349
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007E5E RID: 32350
		internal static int __PropertyOffset_Location;

		// Token: 0x04007E5F RID: 32351
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04007E60 RID: 32352
		internal static int __PropertyOffset_FOV;
	}
}
