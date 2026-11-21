using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003F7 RID: 1015
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroParameterArrayVector")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroParameterArrayVector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060063D3 RID: 25555 RVA: 0x0008EB40 File Offset: 0x0008CD40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroParameterArrayVector._ScriptStructPtr != 0) ? FKuroParameterArrayVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroParameterArrayVector", ref FKuroParameterArrayVector._ScriptStructPtr);
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x060063D4 RID: 25556 RVA: 0x0008EB64 File Offset: 0x0008CD64
		// (set) Token: 0x060063D5 RID: 25557 RVA: 0x0008EB78 File Offset: 0x0008CD78
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroParameterArrayVector.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroParameterArrayVector.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x060063D6 RID: 25558 RVA: 0x0008EB90 File Offset: 0x0008CD90
		// (set) Token: 0x060063D7 RID: 25559 RVA: 0x0008EBD3 File Offset: 0x0008CDD3
		public TArray<FVector> Value
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new TArray<FVector>(base.NativePtr + (IntPtr)FKuroParameterArrayVector.__PropertyOffset_Value, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Value.CopyAssign(value);
			}
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x0008EBE1 File Offset: 0x0008CDE1
		public FKuroParameterArrayVector()
		{
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x0008EBE9 File Offset: 0x0008CDE9
		protected override IntPtr GetUStructPtr()
		{
			return FKuroParameterArrayVector.StaticStruct();
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x0008EBF5 File Offset: 0x0008CDF5
		[NullableContext(2)]
		public FKuroParameterArrayVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x0008EBFF File Offset: 0x0008CDFF
		public FKuroParameterArrayVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x0008EC0A File Offset: 0x0008CE0A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroParameterArrayVector(Pointer, false, true);
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x0008EC14 File Offset: 0x0008CE14
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroParameterArrayVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002A2C RID: 10796
		public const string __ObjectPath = "/Script/KuroGameplay.KuroParameterArrayVector";

		// Token: 0x04002A2D RID: 10797
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002A2E RID: 10798
		internal static int __PropertyOffset_Name;

		// Token: 0x04002A2F RID: 10799
		internal static int __PropertyOffset_Value;

		// Token: 0x04002A30 RID: 10800
		[Nullable(2)]
		private TArray<FVector> _Value;
	}
}
