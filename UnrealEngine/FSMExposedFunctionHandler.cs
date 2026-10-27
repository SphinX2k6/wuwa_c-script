using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002883 RID: 10371
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMExposedFunctionHandler")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSMExposedFunctionHandler : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026625 RID: 157221 RVA: 0x003A571D File Offset: 0x003A391D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMExposedFunctionHandler._ScriptStructPtr != 0) ? FSMExposedFunctionHandler._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMExposedFunctionHandler", ref FSMExposedFunctionHandler._ScriptStructPtr);
		}

		// Token: 0x17009406 RID: 37894
		// (get) Token: 0x06026626 RID: 157222 RVA: 0x003A5741 File Offset: 0x003A3941
		// (set) Token: 0x06026627 RID: 157223 RVA: 0x003A5755 File Offset: 0x003A3955
		public unsafe FName BoundFunction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMExposedFunctionHandler.__PropertyOffset_BoundFunction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMExposedFunctionHandler.__PropertyOffset_BoundFunction) = value;
			}
		}

		// Token: 0x17009407 RID: 37895
		// (get) Token: 0x06026628 RID: 157224 RVA: 0x003A576A File Offset: 0x003A396A
		// (set) Token: 0x06026629 RID: 157225 RVA: 0x003A577A File Offset: 0x003A397A
		public unsafe ESMExposedFunctionExecutionType ExecutionType
		{
			get
			{
				return (ESMExposedFunctionExecutionType)(*(base.NativePtr + (IntPtr)FSMExposedFunctionHandler.__PropertyOffset_ExecutionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMExposedFunctionHandler.__PropertyOffset_ExecutionType) = (byte)value;
			}
		}

		// Token: 0x17009408 RID: 37896
		// (get) Token: 0x0602662A RID: 157226 RVA: 0x003A578B File Offset: 0x003A398B
		// (set) Token: 0x0602662B RID: 157227 RVA: 0x003A579F File Offset: 0x003A399F
		public unsafe UFunction Function
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFunction>(base.NativePtr / (IntPtr)sizeof(void*) + FSMExposedFunctionHandler.__PropertyOffset_Function);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSMExposedFunctionHandler.__PropertyOffset_Function, value);
			}
		}

		// Token: 0x17009409 RID: 37897
		// (get) Token: 0x0602662C RID: 157228 RVA: 0x003A57B4 File Offset: 0x003A39B4
		// (set) Token: 0x0602662D RID: 157229 RVA: 0x003A57C8 File Offset: 0x003A39C8
		public unsafe UObject OwnerObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSMExposedFunctionHandler.__PropertyOffset_OwnerObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSMExposedFunctionHandler.__PropertyOffset_OwnerObject, value);
			}
		}

		// Token: 0x0602662E RID: 157230 RVA: 0x003A57DD File Offset: 0x003A39DD
		public FSMExposedFunctionHandler()
		{
		}

		// Token: 0x0602662F RID: 157231 RVA: 0x003A57E5 File Offset: 0x003A39E5
		[NullableContext(1)]
		public FSMExposedFunctionHandler(FName BoundFunction, ESMExposedFunctionExecutionType ExecutionType, UFunction Function, UObject OwnerObject)
		{
			this.BoundFunction = BoundFunction;
			this.ExecutionType = ExecutionType;
			this.Function = Function;
			this.OwnerObject = OwnerObject;
		}

		// Token: 0x06026630 RID: 157232 RVA: 0x003A580A File Offset: 0x003A3A0A
		protected override IntPtr GetUStructPtr()
		{
			return FSMExposedFunctionHandler.StaticStruct();
		}

		// Token: 0x06026631 RID: 157233 RVA: 0x003A5816 File Offset: 0x003A3A16
		public FSMExposedFunctionHandler(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026632 RID: 157234 RVA: 0x003A5820 File Offset: 0x003A3A20
		public FSMExposedFunctionHandler(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026633 RID: 157235 RVA: 0x003A582B File Offset: 0x003A3A2B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMExposedFunctionHandler(Pointer, false, true);
		}

		// Token: 0x06026634 RID: 157236 RVA: 0x003A5835 File Offset: 0x003A3A35
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMExposedFunctionHandler(Pointer, MemoryOwner);
		}

		// Token: 0x040150D5 RID: 86229
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.SMExposedFunctionHandler";

		// Token: 0x040150D6 RID: 86230
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040150D7 RID: 86231
		internal static int __PropertyOffset_BoundFunction;

		// Token: 0x040150D8 RID: 86232
		internal static int __PropertyOffset_ExecutionType;

		// Token: 0x040150D9 RID: 86233
		internal static int __PropertyOffset_Function;

		// Token: 0x040150DA RID: 86234
		internal static int __PropertyOffset_OwnerObject;
	}
}
