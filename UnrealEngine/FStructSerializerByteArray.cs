using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200271F RID: 10015
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Serialization.StructSerializerByteArray")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FStructSerializerByteArray : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060251B2 RID: 151986 RVA: 0x0036F3B4 File Offset: 0x0036D5B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructSerializerByteArray._ScriptStructPtr != 0) ? FStructSerializerByteArray._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Serialization.StructSerializerByteArray", ref FStructSerializerByteArray._ScriptStructPtr);
		}

		// Token: 0x17008F2E RID: 36654
		// (get) Token: 0x060251B3 RID: 151987 RVA: 0x0036F3D8 File Offset: 0x0036D5D8
		// (set) Token: 0x060251B4 RID: 151988 RVA: 0x0036F3E8 File Offset: 0x0036D5E8
		public unsafe int Dummy1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerByteArray.__PropertyOffset_Dummy1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerByteArray.__PropertyOffset_Dummy1) = value;
			}
		}

		// Token: 0x17008F2F RID: 36655
		// (get) Token: 0x060251B5 RID: 151989 RVA: 0x0036F3FC File Offset: 0x0036D5FC
		// (set) Token: 0x060251B6 RID: 151990 RVA: 0x0036F43F File Offset: 0x0036D63F
		public TArray<byte> ByteArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ByteArray) == null)
				{
					result = (this._ByteArray = new TArray<byte>(base.NativePtr + (IntPtr)FStructSerializerByteArray.__PropertyOffset_ByteArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ByteArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F30 RID: 36656
		// (get) Token: 0x060251B7 RID: 151991 RVA: 0x0036F44D File Offset: 0x0036D64D
		// (set) Token: 0x060251B8 RID: 151992 RVA: 0x0036F45D File Offset: 0x0036D65D
		public unsafe int Dummy2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerByteArray.__PropertyOffset_Dummy2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerByteArray.__PropertyOffset_Dummy2) = value;
			}
		}

		// Token: 0x17008F31 RID: 36657
		// (get) Token: 0x060251B9 RID: 151993 RVA: 0x0036F470 File Offset: 0x0036D670
		// (set) Token: 0x060251BA RID: 151994 RVA: 0x0036F4B3 File Offset: 0x0036D6B3
		public TArray<sbyte> Int8Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<sbyte> result;
				if ((result = this._Int8Array) == null)
				{
					result = (this._Int8Array = new TArray<sbyte>(base.NativePtr + (IntPtr)FStructSerializerByteArray.__PropertyOffset_Int8Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int8Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F32 RID: 36658
		// (get) Token: 0x060251BB RID: 151995 RVA: 0x0036F4C1 File Offset: 0x0036D6C1
		// (set) Token: 0x060251BC RID: 151996 RVA: 0x0036F4D1 File Offset: 0x0036D6D1
		public unsafe int Dummy3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerByteArray.__PropertyOffset_Dummy3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerByteArray.__PropertyOffset_Dummy3) = value;
			}
		}

		// Token: 0x060251BD RID: 151997 RVA: 0x0036F4E2 File Offset: 0x0036D6E2
		public FStructSerializerByteArray()
		{
		}

		// Token: 0x060251BE RID: 151998 RVA: 0x0036F4EA File Offset: 0x0036D6EA
		public FStructSerializerByteArray(int Dummy1, TArray<byte> ByteArray, int Dummy2, TArray<sbyte> Int8Array, int Dummy3)
		{
			this.Dummy1 = Dummy1;
			this.ByteArray = ByteArray;
			this.Dummy2 = Dummy2;
			this.Int8Array = Int8Array;
			this.Dummy3 = Dummy3;
		}

		// Token: 0x060251BF RID: 151999 RVA: 0x0036F517 File Offset: 0x0036D717
		protected override IntPtr GetUStructPtr()
		{
			return FStructSerializerByteArray.StaticStruct();
		}

		// Token: 0x060251C0 RID: 152000 RVA: 0x0036F523 File Offset: 0x0036D723
		[NullableContext(2)]
		public FStructSerializerByteArray(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060251C1 RID: 152001 RVA: 0x0036F52D File Offset: 0x0036D72D
		public FStructSerializerByteArray(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060251C2 RID: 152002 RVA: 0x0036F538 File Offset: 0x0036D738
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructSerializerByteArray(Pointer, false, true);
		}

		// Token: 0x060251C3 RID: 152003 RVA: 0x0036F542 File Offset: 0x0036D742
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructSerializerByteArray(Pointer, MemoryOwner);
		}

		// Token: 0x04013FEF RID: 81903
		public const string __ObjectPath = "/Script/Serialization.StructSerializerByteArray";

		// Token: 0x04013FF0 RID: 81904
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013FF1 RID: 81905
		internal static int __PropertyOffset_Dummy1;

		// Token: 0x04013FF2 RID: 81906
		internal static int __PropertyOffset_ByteArray;

		// Token: 0x04013FF3 RID: 81907
		[Nullable(2)]
		private TArray<byte> _ByteArray;

		// Token: 0x04013FF4 RID: 81908
		internal static int __PropertyOffset_Dummy2;

		// Token: 0x04013FF5 RID: 81909
		internal static int __PropertyOffset_Int8Array;

		// Token: 0x04013FF6 RID: 81910
		[Nullable(2)]
		private TArray<sbyte> _Int8Array;

		// Token: 0x04013FF7 RID: 81911
		internal static int __PropertyOffset_Dummy3;
	}
}
