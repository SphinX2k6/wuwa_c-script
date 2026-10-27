using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004C3 RID: 1219
	[UnrealObjectPath("/Script/ControlRig.ControlRigDrawInstruction")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FControlRigDrawInstruction : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600417F RID: 16767 RVA: 0x000621D4 File Offset: 0x000603D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigDrawInstruction._ScriptStructPtr != 0) ? FControlRigDrawInstruction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigDrawInstruction", ref FControlRigDrawInstruction._ScriptStructPtr);
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x06004180 RID: 16768 RVA: 0x000621F8 File Offset: 0x000603F8
		// (set) Token: 0x06004181 RID: 16769 RVA: 0x0006220C File Offset: 0x0006040C
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x06004182 RID: 16770 RVA: 0x00062221 File Offset: 0x00060421
		// (set) Token: 0x06004183 RID: 16771 RVA: 0x00062235 File Offset: 0x00060435
		public unsafe TEnumAsByte<EControlRigDrawSettings> PrimitiveType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_PrimitiveType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_PrimitiveType) = value;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x06004184 RID: 16772 RVA: 0x0006224C File Offset: 0x0006044C
		// (set) Token: 0x06004185 RID: 16773 RVA: 0x0006228F File Offset: 0x0006048F
		[Nullable(1)]
		public TArray<FVector> Positions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Positions) == null)
				{
					result = (this._Positions = new TArray<FVector>(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_Positions, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Positions.CopyAssign(value);
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x06004186 RID: 16774 RVA: 0x0006229D File Offset: 0x0006049D
		// (set) Token: 0x06004187 RID: 16775 RVA: 0x000622B1 File Offset: 0x000604B1
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x06004188 RID: 16776 RVA: 0x000622C6 File Offset: 0x000604C6
		// (set) Token: 0x06004189 RID: 16777 RVA: 0x000622D6 File Offset: 0x000604D6
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x0600418A RID: 16778 RVA: 0x000622E7 File Offset: 0x000604E7
		// (set) Token: 0x0600418B RID: 16779 RVA: 0x000622FB File Offset: 0x000604FB
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigDrawInstruction.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x00062310 File Offset: 0x00060510
		public FControlRigDrawInstruction()
		{
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x00062318 File Offset: 0x00060518
		public FControlRigDrawInstruction(FName Name, TEnumAsByte<EControlRigDrawSettings> PrimitiveType, [Nullable(1)] TArray<FVector> Positions, FLinearColor Color, float Thickness, FTransform Transform)
		{
			this.Name = Name;
			this.PrimitiveType = PrimitiveType;
			this.Positions = Positions;
			this.Color = Color;
			this.Thickness = Thickness;
			this.Transform = Transform;
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x0006234D File Offset: 0x0006054D
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigDrawInstruction.StaticStruct();
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x00062359 File Offset: 0x00060559
		[NullableContext(2)]
		public FControlRigDrawInstruction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x00062363 File Offset: 0x00060563
		public FControlRigDrawInstruction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x0006236E File Offset: 0x0006056E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigDrawInstruction(Pointer, false, true);
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x00062378 File Offset: 0x00060578
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigDrawInstruction(Pointer, MemoryOwner);
		}

		// Token: 0x04001F2B RID: 7979
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.ControlRigDrawInstruction";

		// Token: 0x04001F2C RID: 7980
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F2D RID: 7981
		internal static int __PropertyOffset_Name;

		// Token: 0x04001F2E RID: 7982
		internal static int __PropertyOffset_PrimitiveType;

		// Token: 0x04001F2F RID: 7983
		internal static int __PropertyOffset_Positions;

		// Token: 0x04001F30 RID: 7984
		[Nullable(2)]
		private TArray<FVector> _Positions;

		// Token: 0x04001F31 RID: 7985
		internal static int __PropertyOffset_Color;

		// Token: 0x04001F32 RID: 7986
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04001F33 RID: 7987
		internal static int __PropertyOffset_Transform;
	}
}
