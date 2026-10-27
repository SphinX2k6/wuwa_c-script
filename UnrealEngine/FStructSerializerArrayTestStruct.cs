using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200271C RID: 10012
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Serialization.StructSerializerArrayTestStruct")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FStructSerializerArrayTestStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06025166 RID: 151910 RVA: 0x0036EB55 File Offset: 0x0036CD55
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStructSerializerArrayTestStruct._ScriptStructPtr != 0) ? FStructSerializerArrayTestStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Serialization.StructSerializerArrayTestStruct", ref FStructSerializerArrayTestStruct._ScriptStructPtr);
		}

		// Token: 0x17008F14 RID: 36628
		// (get) Token: 0x06025167 RID: 151911 RVA: 0x0036EB7C File Offset: 0x0036CD7C
		// (set) Token: 0x06025168 RID: 151912 RVA: 0x0036EBBF File Offset: 0x0036CDBF
		public TArray<int> Int32Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Int32Array) == null)
				{
					result = (this._Int32Array = new TArray<int>(base.NativePtr + (IntPtr)FStructSerializerArrayTestStruct.__PropertyOffset_Int32Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Int32Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F15 RID: 36629
		// (get) Token: 0x06025169 RID: 151913 RVA: 0x0036EBD0 File Offset: 0x0036CDD0
		// (set) Token: 0x0602516A RID: 151914 RVA: 0x0036EC13 File Offset: 0x0036CE13
		public TArray<byte> ByteArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._ByteArray) == null)
				{
					result = (this._ByteArray = new TArray<byte>(base.NativePtr + (IntPtr)FStructSerializerArrayTestStruct.__PropertyOffset_ByteArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ByteArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F16 RID: 36630
		// (get) Token: 0x0602516B RID: 151915 RVA: 0x0036EC21 File Offset: 0x0036CE21
		// (set) Token: 0x0602516C RID: 151916 RVA: 0x0036EC31 File Offset: 0x0036CE31
		public unsafe int StaticSingleElement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStructSerializerArrayTestStruct.__PropertyOffset_StaticSingleElement);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStructSerializerArrayTestStruct.__PropertyOffset_StaticSingleElement) = value;
			}
		}

		// Token: 0x17008F17 RID: 36631
		// (get) Token: 0x0602516D RID: 151917 RVA: 0x0036EC44 File Offset: 0x0036CE44
		// (set) Token: 0x0602516E RID: 151918 RVA: 0x0036EC88 File Offset: 0x0036CE88
		public TFixedArray<int> StaticInt32Array
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<int> result;
				if ((result = this._StaticInt32Array) == null)
				{
					result = (this._StaticInt32Array = new TFixedArray<int>(base.NativePtr + (IntPtr)FStructSerializerArrayTestStruct.__PropertyOffset_StaticInt32Array, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticInt32Array.CopyAssign(value);
			}
		}

		// Token: 0x17008F18 RID: 36632
		// (get) Token: 0x0602516F RID: 151919 RVA: 0x0036EC98 File Offset: 0x0036CE98
		// (set) Token: 0x06025170 RID: 151920 RVA: 0x0036ECDC File Offset: 0x0036CEDC
		public TFixedArray<float> StaticFloatArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<float> result;
				if ((result = this._StaticFloatArray) == null)
				{
					result = (this._StaticFloatArray = new TFixedArray<float>(base.NativePtr + (IntPtr)FStructSerializerArrayTestStruct.__PropertyOffset_StaticFloatArray, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StaticFloatArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F19 RID: 36633
		// (get) Token: 0x06025171 RID: 151921 RVA: 0x0036ECEC File Offset: 0x0036CEEC
		// (set) Token: 0x06025172 RID: 151922 RVA: 0x0036ED2F File Offset: 0x0036CF2F
		public TArray<FVector> VectorArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._VectorArray) == null)
				{
					result = (this._VectorArray = new TArray<FVector>(base.NativePtr + (IntPtr)FStructSerializerArrayTestStruct.__PropertyOffset_VectorArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorArray.CopyAssign(value);
			}
		}

		// Token: 0x17008F1A RID: 36634
		// (get) Token: 0x06025173 RID: 151923 RVA: 0x0036ED40 File Offset: 0x0036CF40
		// (set) Token: 0x06025174 RID: 151924 RVA: 0x0036ED83 File Offset: 0x0036CF83
		public TArray<FStructSerializerBuiltinTestStruct> StructArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FStructSerializerBuiltinTestStruct> result;
				if ((result = this._StructArray) == null)
				{
					result = (this._StructArray = new TArray<FStructSerializerBuiltinTestStruct>(base.NativePtr + (IntPtr)FStructSerializerArrayTestStruct.__PropertyOffset_StructArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.StructArray.CopyAssign(value);
			}
		}

		// Token: 0x06025175 RID: 151925 RVA: 0x0036ED91 File Offset: 0x0036CF91
		public FStructSerializerArrayTestStruct()
		{
		}

		// Token: 0x06025176 RID: 151926 RVA: 0x0036ED99 File Offset: 0x0036CF99
		public FStructSerializerArrayTestStruct(TArray<int> Int32Array, TArray<byte> ByteArray, int StaticSingleElement, TFixedArray<int> StaticInt32Array, TFixedArray<float> StaticFloatArray, TArray<FVector> VectorArray, TArray<FStructSerializerBuiltinTestStruct> StructArray)
		{
			this.Int32Array = Int32Array;
			this.ByteArray = ByteArray;
			this.StaticSingleElement = StaticSingleElement;
			this.StaticInt32Array = StaticInt32Array;
			this.StaticFloatArray = StaticFloatArray;
			this.VectorArray = VectorArray;
			this.StructArray = StructArray;
		}

		// Token: 0x06025177 RID: 151927 RVA: 0x0036EDD6 File Offset: 0x0036CFD6
		protected override IntPtr GetUStructPtr()
		{
			return FStructSerializerArrayTestStruct.StaticStruct();
		}

		// Token: 0x06025178 RID: 151928 RVA: 0x0036EDE2 File Offset: 0x0036CFE2
		[NullableContext(2)]
		public FStructSerializerArrayTestStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06025179 RID: 151929 RVA: 0x0036EDEC File Offset: 0x0036CFEC
		public FStructSerializerArrayTestStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602517A RID: 151930 RVA: 0x0036EDF7 File Offset: 0x0036CFF7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStructSerializerArrayTestStruct(Pointer, false, true);
		}

		// Token: 0x0602517B RID: 151931 RVA: 0x0036EE01 File Offset: 0x0036D001
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStructSerializerArrayTestStruct(Pointer, MemoryOwner);
		}

		// Token: 0x04013FC0 RID: 81856
		public const string __ObjectPath = "/Script/Serialization.StructSerializerArrayTestStruct";

		// Token: 0x04013FC1 RID: 81857
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013FC2 RID: 81858
		internal static int __PropertyOffset_Int32Array;

		// Token: 0x04013FC3 RID: 81859
		[Nullable(2)]
		private TArray<int> _Int32Array;

		// Token: 0x04013FC4 RID: 81860
		internal static int __PropertyOffset_ByteArray;

		// Token: 0x04013FC5 RID: 81861
		[Nullable(2)]
		private TArray<byte> _ByteArray;

		// Token: 0x04013FC6 RID: 81862
		internal static int __PropertyOffset_StaticSingleElement;

		// Token: 0x04013FC7 RID: 81863
		internal static int __PropertyOffset_StaticInt32Array;

		// Token: 0x04013FC8 RID: 81864
		[Nullable(2)]
		private TFixedArray<int> _StaticInt32Array;

		// Token: 0x04013FC9 RID: 81865
		internal static int __PropertyOffset_StaticFloatArray;

		// Token: 0x04013FCA RID: 81866
		[Nullable(2)]
		private TFixedArray<float> _StaticFloatArray;

		// Token: 0x04013FCB RID: 81867
		internal static int __PropertyOffset_VectorArray;

		// Token: 0x04013FCC RID: 81868
		[Nullable(2)]
		private TArray<FVector> _VectorArray;

		// Token: 0x04013FCD RID: 81869
		internal static int __PropertyOffset_StructArray;

		// Token: 0x04013FCE RID: 81870
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FStructSerializerBuiltinTestStruct> _StructArray;
	}
}
