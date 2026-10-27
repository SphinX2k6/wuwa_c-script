using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200106B RID: 4203
	[UnrealObjectPath("/Script/Engine.RBFDrivenWeight")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRBFDrivenWeight : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EF19 RID: 61209 RVA: 0x001629EC File Offset: 0x00160BEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRBFDrivenWeight._ScriptStructPtr != 0) ? FRBFDrivenWeight._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RBFDrivenWeight", ref FRBFDrivenWeight._ScriptStructPtr);
		}

		// Token: 0x170039DB RID: 14811
		// (get) Token: 0x0600EF1A RID: 61210 RVA: 0x00162A10 File Offset: 0x00160C10
		// (set) Token: 0x0600EF1B RID: 61211 RVA: 0x00162A24 File Offset: 0x00160C24
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFDrivenWeight.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFDrivenWeight.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x170039DC RID: 14812
		// (get) Token: 0x0600EF1C RID: 61212 RVA: 0x00162A39 File Offset: 0x00160C39
		// (set) Token: 0x0600EF1D RID: 61213 RVA: 0x00162A49 File Offset: 0x00160C49
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRBFDrivenWeight.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRBFDrivenWeight.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0600EF1E RID: 61214 RVA: 0x00162A5A File Offset: 0x00160C5A
		public FRBFDrivenWeight()
		{
		}

		// Token: 0x0600EF1F RID: 61215 RVA: 0x00162A62 File Offset: 0x00160C62
		public FRBFDrivenWeight(FName Name, float Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0600EF20 RID: 61216 RVA: 0x00162A78 File Offset: 0x00160C78
		protected override IntPtr GetUStructPtr()
		{
			return FRBFDrivenWeight.StaticStruct();
		}

		// Token: 0x0600EF21 RID: 61217 RVA: 0x00162A84 File Offset: 0x00160C84
		[NullableContext(2)]
		public FRBFDrivenWeight(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EF22 RID: 61218 RVA: 0x00162A8E File Offset: 0x00160C8E
		public FRBFDrivenWeight(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EF23 RID: 61219 RVA: 0x00162A99 File Offset: 0x00160C99
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRBFDrivenWeight(Pointer, false, true);
		}

		// Token: 0x0600EF24 RID: 61220 RVA: 0x00162AA3 File Offset: 0x00160CA3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRBFDrivenWeight(Pointer, MemoryOwner);
		}

		// Token: 0x04008162 RID: 33122
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RBFDrivenWeight";

		// Token: 0x04008163 RID: 33123
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008164 RID: 33124
		internal static int __PropertyOffset_Name;

		// Token: 0x04008165 RID: 33125
		internal static int __PropertyOffset_Value;
	}
}
