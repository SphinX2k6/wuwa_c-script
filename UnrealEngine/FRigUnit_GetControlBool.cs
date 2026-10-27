using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005B0 RID: 1456
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetControlBool")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRigUnit_GetControlBool : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004E77 RID: 20087 RVA: 0x00073EF9 File Offset: 0x000720F9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetControlBool._ScriptStructPtr != 0) ? FRigUnit_GetControlBool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetControlBool", ref FRigUnit_GetControlBool._ScriptStructPtr);
		}

		// Token: 0x17001351 RID: 4945
		// (get) Token: 0x06004E78 RID: 20088 RVA: 0x00073F1D File Offset: 0x0007211D
		// (set) Token: 0x06004E79 RID: 20089 RVA: 0x00073F31 File Offset: 0x00072131
		public unsafe FName Control
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlBool.__PropertyOffset_Control);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlBool.__PropertyOffset_Control) = value;
			}
		}

		// Token: 0x17001352 RID: 4946
		// (get) Token: 0x06004E7A RID: 20090 RVA: 0x00073F46 File Offset: 0x00072146
		// (set) Token: 0x06004E7B RID: 20091 RVA: 0x00073F56 File Offset: 0x00072156
		public unsafe bool BoolValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetControlBool.__PropertyOffset_BoolValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetControlBool.__PropertyOffset_BoolValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001353 RID: 4947
		// (get) Token: 0x06004E7C RID: 20092 RVA: 0x00073F68 File Offset: 0x00072168
		// (set) Token: 0x06004E7D RID: 20093 RVA: 0x00073FAB File Offset: 0x000721AB
		public FCachedRigElement CachedControlIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedControlIndex) == null)
				{
					result = (this._CachedControlIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_GetControlBool.__PropertyOffset_CachedControlIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_GetControlBool.__PropertyOffset_CachedControlIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x00073FCC File Offset: 0x000721CC
		public FRigUnit_GetControlBool()
		{
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x00073FD4 File Offset: 0x000721D4
		public FRigUnit_GetControlBool(FName Control, bool BoolValue, FCachedRigElement CachedControlIndex)
		{
			this.Control = Control;
			this.BoolValue = BoolValue;
			this.CachedControlIndex = CachedControlIndex;
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x00073FF1 File Offset: 0x000721F1
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetControlBool.StaticStruct();
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x00073FFD File Offset: 0x000721FD
		[NullableContext(2)]
		public FRigUnit_GetControlBool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x00074007 File Offset: 0x00072207
		public FRigUnit_GetControlBool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x00074012 File Offset: 0x00072212
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetControlBool(Pointer, false, true);
		}

		// Token: 0x06004E84 RID: 20100 RVA: 0x0007401C File Offset: 0x0007221C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetControlBool(Pointer, MemoryOwner);
		}

		// Token: 0x040025EA RID: 9706
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetControlBool";

		// Token: 0x040025EB RID: 9707
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040025EC RID: 9708
		internal static int __PropertyOffset_Control;

		// Token: 0x040025ED RID: 9709
		internal static int __PropertyOffset_BoolValue;

		// Token: 0x040025EE RID: 9710
		internal static int __PropertyOffset_CachedControlIndex;

		// Token: 0x040025EF RID: 9711
		[Nullable(2)]
		private FCachedRigElement _CachedControlIndex;
	}
}
