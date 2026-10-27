using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026CC RID: 9932
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RigVM.RigVMRegisterOffset")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FRigVMRegisterOffset : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024E04 RID: 151044 RVA: 0x00368C2C File Offset: 0x00366E2C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigVMRegisterOffset._ScriptStructPtr != 0) ? FRigVMRegisterOffset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/RigVM.RigVMRegisterOffset", ref FRigVMRegisterOffset._ScriptStructPtr);
		}

		// Token: 0x17008E6D RID: 36461
		// (get) Token: 0x06024E05 RID: 151045 RVA: 0x00368C50 File Offset: 0x00366E50
		// (set) Token: 0x06024E06 RID: 151046 RVA: 0x00368C93 File Offset: 0x00366E93
		public TArray<int> Segments
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Segments) == null)
				{
					result = (this._Segments = new TArray<int>(base.NativePtr + (IntPtr)FRigVMRegisterOffset.__PropertyOffset_Segments, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Segments.CopyAssign(value);
			}
		}

		// Token: 0x17008E6E RID: 36462
		// (get) Token: 0x06024E07 RID: 151047 RVA: 0x00368CA1 File Offset: 0x00366EA1
		// (set) Token: 0x06024E08 RID: 151048 RVA: 0x00368CB1 File Offset: 0x00366EB1
		public unsafe ERigVMRegisterType Type
		{
			get
			{
				return (ERigVMRegisterType)(*(base.NativePtr + (IntPtr)FRigVMRegisterOffset.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegisterOffset.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x17008E6F RID: 36463
		// (get) Token: 0x06024E09 RID: 151049 RVA: 0x00368CC2 File Offset: 0x00366EC2
		// (set) Token: 0x06024E0A RID: 151050 RVA: 0x00368CD6 File Offset: 0x00366ED6
		public unsafe FName CPPType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegisterOffset.__PropertyOffset_CPPType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegisterOffset.__PropertyOffset_CPPType) = value;
			}
		}

		// Token: 0x17008E70 RID: 36464
		// (get) Token: 0x06024E0B RID: 151051 RVA: 0x00368CEB File Offset: 0x00366EEB
		// (set) Token: 0x06024E0C RID: 151052 RVA: 0x00368CFF File Offset: 0x00366EFF
		[Nullable(2)]
		public unsafe UScriptStruct ScriptStruct
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UScriptStruct>(base.NativePtr / (IntPtr)sizeof(void*) + FRigVMRegisterOffset.__PropertyOffset_ScriptStruct);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRigVMRegisterOffset.__PropertyOffset_ScriptStruct, value);
			}
		}

		// Token: 0x17008E71 RID: 36465
		// (get) Token: 0x06024E0D RID: 151053 RVA: 0x00368D14 File Offset: 0x00366F14
		// (set) Token: 0x06024E0E RID: 151054 RVA: 0x00368D28 File Offset: 0x00366F28
		[Nullable(2)]
		public unsafe UScriptStruct ParentScriptStruct
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UScriptStruct>(base.NativePtr / (IntPtr)sizeof(void*) + FRigVMRegisterOffset.__PropertyOffset_ParentScriptStruct);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRigVMRegisterOffset.__PropertyOffset_ParentScriptStruct, value);
			}
		}

		// Token: 0x17008E72 RID: 36466
		// (get) Token: 0x06024E0F RID: 151055 RVA: 0x00368D3D File Offset: 0x00366F3D
		// (set) Token: 0x06024E10 RID: 151056 RVA: 0x00368D4D File Offset: 0x00366F4D
		public unsafe int ArrayIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegisterOffset.__PropertyOffset_ArrayIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegisterOffset.__PropertyOffset_ArrayIndex) = value;
			}
		}

		// Token: 0x17008E73 RID: 36467
		// (get) Token: 0x06024E11 RID: 151057 RVA: 0x00368D5E File Offset: 0x00366F5E
		// (set) Token: 0x06024E12 RID: 151058 RVA: 0x00368D6E File Offset: 0x00366F6E
		public unsafe ushort ElementSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigVMRegisterOffset.__PropertyOffset_ElementSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigVMRegisterOffset.__PropertyOffset_ElementSize) = (short)value;
			}
		}

		// Token: 0x17008E74 RID: 36468
		// (get) Token: 0x06024E13 RID: 151059 RVA: 0x00368D7F File Offset: 0x00366F7F
		// (set) Token: 0x06024E14 RID: 151060 RVA: 0x00368D93 File Offset: 0x00366F93
		public unsafe string CachedSegmentPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRigVMRegisterOffset.__PropertyOffset_CachedSegmentPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRigVMRegisterOffset.__PropertyOffset_CachedSegmentPath)), value);
			}
		}

		// Token: 0x06024E15 RID: 151061 RVA: 0x00368DA8 File Offset: 0x00366FA8
		public FRigVMRegisterOffset()
		{
		}

		// Token: 0x06024E16 RID: 151062 RVA: 0x00368DB0 File Offset: 0x00366FB0
		public FRigVMRegisterOffset(TArray<int> Segments, ERigVMRegisterType Type, FName CPPType, UScriptStruct ScriptStruct, UScriptStruct ParentScriptStruct, int ArrayIndex, ushort ElementSize, string CachedSegmentPath)
		{
			this.Segments = Segments;
			this.Type = Type;
			this.CPPType = CPPType;
			this.ScriptStruct = ScriptStruct;
			this.ParentScriptStruct = ParentScriptStruct;
			this.ArrayIndex = ArrayIndex;
			this.ElementSize = ElementSize;
			this.CachedSegmentPath = CachedSegmentPath;
		}

		// Token: 0x06024E17 RID: 151063 RVA: 0x00368E00 File Offset: 0x00367000
		protected override IntPtr GetUStructPtr()
		{
			return FRigVMRegisterOffset.StaticStruct();
		}

		// Token: 0x06024E18 RID: 151064 RVA: 0x00368E0C File Offset: 0x0036700C
		[NullableContext(2)]
		public FRigVMRegisterOffset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024E19 RID: 151065 RVA: 0x00368E16 File Offset: 0x00367016
		public FRigVMRegisterOffset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024E1A RID: 151066 RVA: 0x00368E21 File Offset: 0x00367021
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigVMRegisterOffset(Pointer, false, true);
		}

		// Token: 0x06024E1B RID: 151067 RVA: 0x00368E2B File Offset: 0x0036702B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigVMRegisterOffset(Pointer, MemoryOwner);
		}

		// Token: 0x04013DD9 RID: 81369
		public const string __ObjectPath = "/Script/RigVM.RigVMRegisterOffset";

		// Token: 0x04013DDA RID: 81370
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013DDB RID: 81371
		internal static int __PropertyOffset_Segments;

		// Token: 0x04013DDC RID: 81372
		[Nullable(2)]
		private TArray<int> _Segments;

		// Token: 0x04013DDD RID: 81373
		internal static int __PropertyOffset_Type;

		// Token: 0x04013DDE RID: 81374
		internal static int __PropertyOffset_CPPType;

		// Token: 0x04013DDF RID: 81375
		internal static int __PropertyOffset_ScriptStruct;

		// Token: 0x04013DE0 RID: 81376
		internal static int __PropertyOffset_ParentScriptStruct;

		// Token: 0x04013DE1 RID: 81377
		internal static int __PropertyOffset_ArrayIndex;

		// Token: 0x04013DE2 RID: 81378
		internal static int __PropertyOffset_ElementSize;

		// Token: 0x04013DE3 RID: 81379
		internal static int __PropertyOffset_CachedSegmentPath;
	}
}
