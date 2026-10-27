using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026B8 RID: 9912
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RigVM.RigVM")]
	[UnrealStructLayout(808, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 808)]
	public class URigVM : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024CEA RID: 150762 RVA: 0x003675EB File Offset: 0x003657EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URigVM._ClassPtr;
		}

		// Token: 0x06024CEB RID: 150763 RVA: 0x003675F8 File Offset: 0x003657F8
		public URigVM() : this(BuiltinUtils.AllocNativeUObject(URigVM.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024CEC RID: 150764 RVA: 0x00367620 File Offset: 0x00365820
		public URigVM(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URigVM.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E3F RID: 36415
		// (get) Token: 0x06024CED RID: 150765 RVA: 0x00367654 File Offset: 0x00365854
		// (set) Token: 0x06024CEE RID: 150766 RVA: 0x0036768D File Offset: 0x0036588D
		public FRigVMMemoryContainer WorkMemoryStorage
		{
			get
			{
				base.FastCheckIsValid();
				FRigVMMemoryContainer result;
				if ((result = this._WorkMemoryStorage) == null)
				{
					result = (this._WorkMemoryStorage = new FRigVMMemoryContainer(base.NativePtr + (IntPtr)URigVM.__PropertyOffset_WorkMemoryStorage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigVMMemoryContainer.StaticStruct(), base.NativePtr + (IntPtr)URigVM.__PropertyOffset_WorkMemoryStorage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008E40 RID: 36416
		// (get) Token: 0x06024CEF RID: 150767 RVA: 0x003676B0 File Offset: 0x003658B0
		// (set) Token: 0x06024CF0 RID: 150768 RVA: 0x003676E9 File Offset: 0x003658E9
		public FRigVMMemoryContainer LiteralMemoryStorage
		{
			get
			{
				base.FastCheckIsValid();
				FRigVMMemoryContainer result;
				if ((result = this._LiteralMemoryStorage) == null)
				{
					result = (this._LiteralMemoryStorage = new FRigVMMemoryContainer(base.NativePtr + (IntPtr)URigVM.__PropertyOffset_LiteralMemoryStorage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigVMMemoryContainer.StaticStruct(), base.NativePtr + (IntPtr)URigVM.__PropertyOffset_LiteralMemoryStorage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008E41 RID: 36417
		// (get) Token: 0x06024CF1 RID: 150769 RVA: 0x0036770C File Offset: 0x0036590C
		// (set) Token: 0x06024CF2 RID: 150770 RVA: 0x00367745 File Offset: 0x00365945
		public FRigVMByteCode ByteCodeStorage
		{
			get
			{
				base.FastCheckIsValid();
				FRigVMByteCode result;
				if ((result = this._ByteCodeStorage) == null)
				{
					result = (this._ByteCodeStorage = new FRigVMByteCode(base.NativePtr + (IntPtr)URigVM.__PropertyOffset_ByteCodeStorage, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigVMByteCode.StaticStruct(), base.NativePtr + (IntPtr)URigVM.__PropertyOffset_ByteCodeStorage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008E42 RID: 36418
		// (get) Token: 0x06024CF3 RID: 150771 RVA: 0x00367768 File Offset: 0x00365968
		// (set) Token: 0x06024CF4 RID: 150772 RVA: 0x003677A1 File Offset: 0x003659A1
		public FRigVMInstructionArray Instructions
		{
			get
			{
				base.FastCheckIsValid();
				FRigVMInstructionArray result;
				if ((result = this._Instructions) == null)
				{
					result = (this._Instructions = new FRigVMInstructionArray(base.NativePtr + (IntPtr)URigVM.__PropertyOffset_Instructions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigVMInstructionArray.StaticStruct(), base.NativePtr + (IntPtr)URigVM.__PropertyOffset_Instructions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008E43 RID: 36419
		// (get) Token: 0x06024CF5 RID: 150773 RVA: 0x003677C4 File Offset: 0x003659C4
		// (set) Token: 0x06024CF6 RID: 150774 RVA: 0x003677FD File Offset: 0x003659FD
		public FRigVMExecuteContext Context
		{
			get
			{
				base.FastCheckIsValid();
				FRigVMExecuteContext result;
				if ((result = this._Context) == null)
				{
					result = (this._Context = new FRigVMExecuteContext(base.NativePtr + (IntPtr)URigVM.__PropertyOffset_Context, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigVMExecuteContext.StaticStruct(), base.NativePtr + (IntPtr)URigVM.__PropertyOffset_Context, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008E44 RID: 36420
		// (get) Token: 0x06024CF7 RID: 150775 RVA: 0x00367820 File Offset: 0x00365A20
		// (set) Token: 0x06024CF8 RID: 150776 RVA: 0x00367859 File Offset: 0x00365A59
		public TArray<FName> FunctionNamesStorage
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._FunctionNamesStorage) == null)
				{
					result = (this._FunctionNamesStorage = new TArray<FName>(base.NativePtr + (IntPtr)URigVM.__PropertyOffset_FunctionNamesStorage, this));
				}
				return result;
			}
			set
			{
				this.FunctionNamesStorage.CopyAssign(value);
			}
		}

		// Token: 0x17008E45 RID: 36421
		// (get) Token: 0x06024CF9 RID: 150777 RVA: 0x00367868 File Offset: 0x00365A68
		// (set) Token: 0x06024CFA RID: 150778 RVA: 0x003678A1 File Offset: 0x00365AA1
		public TArray<FRigVMParameter> Parameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRigVMParameter> result;
				if ((result = this._Parameters) == null)
				{
					result = (this._Parameters = new TArray<FRigVMParameter>(base.NativePtr + (IntPtr)URigVM.__PropertyOffset_Parameters, this));
				}
				return result;
			}
			set
			{
				this.Parameters.CopyAssign(value);
			}
		}

		// Token: 0x17008E46 RID: 36422
		// (get) Token: 0x06024CFB RID: 150779 RVA: 0x003678B0 File Offset: 0x00365AB0
		// (set) Token: 0x06024CFC RID: 150780 RVA: 0x003678E9 File Offset: 0x00365AE9
		public TMap<FName, int> ParametersNameMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._ParametersNameMap) == null)
				{
					result = (this._ParametersNameMap = new TMap<FName, int>(base.NativePtr + (IntPtr)URigVM.__PropertyOffset_ParametersNameMap, this));
				}
				return result;
			}
			set
			{
				this.ParametersNameMap.CopyAssign(value);
			}
		}

		// Token: 0x17008E47 RID: 36423
		// (get) Token: 0x06024CFD RID: 150781 RVA: 0x003678F7 File Offset: 0x00365AF7
		// (set) Token: 0x06024CFE RID: 150782 RVA: 0x0036790B File Offset: 0x00365B0B
		[Nullable(2)]
		public unsafe URigVM DeferredVMToCopy
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URigVM>(base.NativePtr / (IntPtr)sizeof(void*) + URigVM.__PropertyOffset_DeferredVMToCopy);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URigVM.__PropertyOffset_DeferredVMToCopy, value);
			}
		}

		// Token: 0x06024CFF RID: 150783 RVA: 0x00367920 File Offset: 0x00365B20
		public unsafe void SetParameterValueVector2D(in FName InParameterName, in FVector2D InValue, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				URigVM.__SetParameterValueVector2D_Internal(base.NativePtr, InParameterName, InValue, InArrayIndex);
			}
		}

		// Token: 0x06024D00 RID: 150784 RVA: 0x00367944 File Offset: 0x00365B44
		public unsafe void SetParameterValueVector(in FName InParameterName, in FVector InValue, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				URigVM.__SetParameterValueVector_Internal(base.NativePtr, InParameterName, InValue, InArrayIndex);
			}
		}

		// Token: 0x06024D01 RID: 150785 RVA: 0x00367968 File Offset: 0x00365B68
		public unsafe void SetParameterValueTransform(in FName InParameterName, in FTransform InValue, int InArrayIndex = 0)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			fixed (FName* ptr2 = &InParameterName)
			{
				void* ptr3 = (void*)ptr2;
				URigVM.__SetParameterValueTransform_Internal(base.NativePtr, InParameterName, ptr, InArrayIndex);
			}
		}

		// Token: 0x06024D02 RID: 150786 RVA: 0x003679A8 File Offset: 0x00365BA8
		public unsafe void SetParameterValueString(in FName InParameterName, string InValue, int InArrayIndex = 0)
		{
			FString fstring = FString.AllocTemp(InValue);
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				URigVM.__SetParameterValueString_Internal(base.NativePtr, InParameterName, fstring, InArrayIndex);
				FString.NativeDestruct(&fstring, 1);
			}
		}

		// Token: 0x06024D03 RID: 150787 RVA: 0x003679DC File Offset: 0x00365BDC
		public unsafe void SetParameterValueQuat(in FName InParameterName, in FQuat InValue, int InArrayIndex = 0)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			fixed (FName* ptr2 = &InParameterName)
			{
				void* ptr3 = (void*)ptr2;
				URigVM.__SetParameterValueQuat_Internal(base.NativePtr, InParameterName, ptr, InArrayIndex);
			}
		}

		// Token: 0x06024D04 RID: 150788 RVA: 0x00367A1C File Offset: 0x00365C1C
		public unsafe void SetParameterValueName(in FName InParameterName, in FName InValue, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &InValue)
				{
					void* ptr4 = (void*)ptr3;
					URigVM.__SetParameterValueName_Internal(base.NativePtr, InParameterName, InValue, InArrayIndex);
					ptr = null;
				}
			}
		}

		// Token: 0x06024D05 RID: 150789 RVA: 0x00367A48 File Offset: 0x00365C48
		public unsafe void SetParameterValueInt(in FName InParameterName, int InValue, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				URigVM.__SetParameterValueInt_Internal(base.NativePtr, InParameterName, InValue, InArrayIndex);
			}
		}

		// Token: 0x06024D06 RID: 150790 RVA: 0x00367A6C File Offset: 0x00365C6C
		public unsafe void SetParameterValueFloat(in FName InParameterName, float InValue, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				URigVM.__SetParameterValueFloat_Internal(base.NativePtr, InParameterName, InValue, InArrayIndex);
			}
		}

		// Token: 0x06024D07 RID: 150791 RVA: 0x00367A90 File Offset: 0x00365C90
		public unsafe void SetParameterValueBool(in FName InParameterName, bool InValue, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				URigVM.__SetParameterValueBool_Internal(base.NativePtr, InParameterName, InValue, InArrayIndex);
			}
		}

		// Token: 0x06024D08 RID: 150792 RVA: 0x00367AB3 File Offset: 0x00365CB3
		public string GetRigVMFunctionName(int InFunctionIndex)
		{
			return FString.ToStringAndDeleteNativePtr(URigVM.__GetRigVMFunctionName_Internal(base.NativePtr, InFunctionIndex));
		}

		// Token: 0x06024D09 RID: 150793 RVA: 0x00367AC8 File Offset: 0x00365CC8
		public unsafe FVector2D GetParameterValueVector2D(in FName InParameterName, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__GetParameterValueVector2D_Internal(base.NativePtr, InParameterName, InArrayIndex);
			}
		}

		// Token: 0x06024D0A RID: 150794 RVA: 0x00367AE8 File Offset: 0x00365CE8
		public unsafe FVector GetParameterValueVector(in FName InParameterName, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__GetParameterValueVector_Internal(base.NativePtr, InParameterName, InArrayIndex);
			}
		}

		// Token: 0x06024D0B RID: 150795 RVA: 0x00367B08 File Offset: 0x00365D08
		public unsafe FTransform GetParameterValueTransform(in FName InParameterName, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__GetParameterValueTransform_Internal(base.NativePtr, InParameterName, InArrayIndex);
			}
		}

		// Token: 0x06024D0C RID: 150796 RVA: 0x00367B28 File Offset: 0x00365D28
		public unsafe string GetParameterValueString(in FName InParameterName, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				return FString.ToStringAndDeleteNativePtr(URigVM.__GetParameterValueString_Internal(base.NativePtr, InParameterName, InArrayIndex));
			}
		}

		// Token: 0x06024D0D RID: 150797 RVA: 0x00367B4C File Offset: 0x00365D4C
		public unsafe FQuat GetParameterValueQuat(in FName InParameterName, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__GetParameterValueQuat_Internal(base.NativePtr, InParameterName, InArrayIndex);
			}
		}

		// Token: 0x06024D0E RID: 150798 RVA: 0x00367B6C File Offset: 0x00365D6C
		public unsafe FName GetParameterValueName(in FName InParameterName, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__GetParameterValueName_Internal(base.NativePtr, InParameterName, InArrayIndex);
			}
		}

		// Token: 0x06024D0F RID: 150799 RVA: 0x00367B8C File Offset: 0x00365D8C
		public unsafe int GetParameterValueInt(in FName InParameterName, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__GetParameterValueInt_Internal(base.NativePtr, InParameterName, InArrayIndex);
			}
		}

		// Token: 0x06024D10 RID: 150800 RVA: 0x00367BAC File Offset: 0x00365DAC
		public unsafe float GetParameterValueFloat(in FName InParameterName, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__GetParameterValueFloat_Internal(base.NativePtr, InParameterName, InArrayIndex);
			}
		}

		// Token: 0x06024D11 RID: 150801 RVA: 0x00367BCC File Offset: 0x00365DCC
		public unsafe bool GetParameterValueBool(in FName InParameterName, int InArrayIndex = 0)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__GetParameterValueBool_Internal(base.NativePtr, InParameterName, InArrayIndex);
			}
		}

		// Token: 0x06024D12 RID: 150802 RVA: 0x00367BEC File Offset: 0x00365DEC
		public unsafe int GetParameterArraySize(in FName InParameterName)
		{
			fixed (FName* ptr = &InParameterName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__GetParameterArraySize_Internal(base.NativePtr, InParameterName);
			}
		}

		// Token: 0x06024D13 RID: 150803 RVA: 0x00367C0C File Offset: 0x00365E0C
		public unsafe bool Execute(in FName InEntryName = null)
		{
			fixed (FName* ptr = &InEntryName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__Execute_Internal(base.NativePtr, InEntryName);
			}
		}

		// Token: 0x06024D14 RID: 150804 RVA: 0x00367C2C File Offset: 0x00365E2C
		[NullableContext(2)]
		public unsafe int AddRigVMFunction(UScriptStruct InRigVMStruct, in FName InMethodName)
		{
			fixed (FName* ptr = &InMethodName)
			{
				void* ptr2 = (void*)ptr;
				return URigVM.__AddRigVMFunction_Internal(base.NativePtr, (InRigVMStruct != null) ? InRigVMStruct.NativePtr : IntPtr.Zero, InMethodName);
			}
		}

		// Token: 0x06024D15 RID: 150805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterValueVector2D_Internal(IntPtr @this, in FName InParameterName, in FVector2D InValue, int InArrayIndex);

		// Token: 0x06024D16 RID: 150806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterValueVector_Internal(IntPtr @this, in FName InParameterName, in FVector InValue, int InArrayIndex);

		// Token: 0x06024D17 RID: 150807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterValueTransform_Internal(IntPtr @this, in FName InParameterName, in FTransform InValue, int InArrayIndex);

		// Token: 0x06024D18 RID: 150808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterValueString_Internal(IntPtr @this, in FName InParameterName, in FString InValue, int InArrayIndex);

		// Token: 0x06024D19 RID: 150809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterValueQuat_Internal(IntPtr @this, in FName InParameterName, in FQuat InValue, int InArrayIndex);

		// Token: 0x06024D1A RID: 150810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterValueName_Internal(IntPtr @this, in FName InParameterName, in FName InValue, int InArrayIndex);

		// Token: 0x06024D1B RID: 150811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterValueInt_Internal(IntPtr @this, in FName InParameterName, int InValue, int InArrayIndex);

		// Token: 0x06024D1C RID: 150812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterValueFloat_Internal(IntPtr @this, in FName InParameterName, float InValue, int InArrayIndex);

		// Token: 0x06024D1D RID: 150813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParameterValueBool_Internal(IntPtr @this, in FName InParameterName, bool InValue, int InArrayIndex);

		// Token: 0x06024D1E RID: 150814
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetRigVMFunctionName_Internal(IntPtr @this, int InFunctionIndex);

		// Token: 0x06024D1F RID: 150815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetParameterValueVector2D_Internal(IntPtr @this, in FName InParameterName, int InArrayIndex);

		// Token: 0x06024D20 RID: 150816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetParameterValueVector_Internal(IntPtr @this, in FName InParameterName, int InArrayIndex);

		// Token: 0x06024D21 RID: 150817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetParameterValueTransform_Internal(IntPtr @this, in FName InParameterName, int InArrayIndex);

		// Token: 0x06024D22 RID: 150818
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetParameterValueString_Internal(IntPtr @this, in FName InParameterName, int InArrayIndex);

		// Token: 0x06024D23 RID: 150819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __GetParameterValueQuat_Internal(IntPtr @this, in FName InParameterName, int InArrayIndex);

		// Token: 0x06024D24 RID: 150820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetParameterValueName_Internal(IntPtr @this, in FName InParameterName, int InArrayIndex);

		// Token: 0x06024D25 RID: 150821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetParameterValueInt_Internal(IntPtr @this, in FName InParameterName, int InArrayIndex);

		// Token: 0x06024D26 RID: 150822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetParameterValueFloat_Internal(IntPtr @this, in FName InParameterName, int InArrayIndex);

		// Token: 0x06024D27 RID: 150823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetParameterValueBool_Internal(IntPtr @this, in FName InParameterName, int InArrayIndex);

		// Token: 0x06024D28 RID: 150824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetParameterArraySize_Internal(IntPtr @this, in FName InParameterName);

		// Token: 0x06024D29 RID: 150825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Execute_Internal(IntPtr @this, in FName InEntryName);

		// Token: 0x06024D2A RID: 150826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddRigVMFunction_Internal(IntPtr @this, IntPtr InRigVMStruct, in FName InMethodName);

		// Token: 0x06024D2B RID: 150827 RVA: 0x00367C5A File Offset: 0x00365E5A
		static URigVM()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RigVM.RigVM");
		}

		// Token: 0x06024D2C RID: 150828 RVA: 0x00367C68 File Offset: 0x00365E68
		protected URigVM(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013D6D RID: 81261
		public new const string __ObjectPath = "/Script/RigVM.RigVM";

		// Token: 0x04013D6E RID: 81262
		private static IntPtr _ClassPtr;

		// Token: 0x04013D6F RID: 81263
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013D70 RID: 81264
		internal static int __PropertyOffset_WorkMemoryStorage;

		// Token: 0x04013D71 RID: 81265
		[Nullable(2)]
		private FRigVMMemoryContainer _WorkMemoryStorage;

		// Token: 0x04013D72 RID: 81266
		internal static int __PropertyOffset_LiteralMemoryStorage;

		// Token: 0x04013D73 RID: 81267
		[Nullable(2)]
		private FRigVMMemoryContainer _LiteralMemoryStorage;

		// Token: 0x04013D74 RID: 81268
		internal static int __PropertyOffset_ByteCodeStorage;

		// Token: 0x04013D75 RID: 81269
		[Nullable(2)]
		private FRigVMByteCode _ByteCodeStorage;

		// Token: 0x04013D76 RID: 81270
		internal static int __PropertyOffset_Instructions;

		// Token: 0x04013D77 RID: 81271
		[Nullable(2)]
		private FRigVMInstructionArray _Instructions;

		// Token: 0x04013D78 RID: 81272
		internal static int __PropertyOffset_Context;

		// Token: 0x04013D79 RID: 81273
		[Nullable(2)]
		private FRigVMExecuteContext _Context;

		// Token: 0x04013D7A RID: 81274
		internal static int __PropertyOffset_FunctionNamesStorage;

		// Token: 0x04013D7B RID: 81275
		[Nullable(2)]
		private TArray<FName> _FunctionNamesStorage;

		// Token: 0x04013D7C RID: 81276
		internal static int __PropertyOffset_Parameters;

		// Token: 0x04013D7D RID: 81277
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRigVMParameter> _Parameters;

		// Token: 0x04013D7E RID: 81278
		internal static int __PropertyOffset_ParametersNameMap;

		// Token: 0x04013D7F RID: 81279
		[Nullable(2)]
		private TMap<FName, int> _ParametersNameMap;

		// Token: 0x04013D80 RID: 81280
		internal static int __PropertyOffset_DeferredVMToCopy;
	}
}
