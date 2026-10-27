using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200051A RID: 1306
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigControlValue")]
	[UnrealStructLayout(128, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FRigControlValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600446A RID: 17514 RVA: 0x00065F5E File Offset: 0x0006415E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigControlValue._ScriptStructPtr != 0) ? FRigControlValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigControlValue", ref FRigControlValue._ScriptStructPtr);
		}

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x00065F84 File Offset: 0x00064184
		// (set) Token: 0x0600446C RID: 17516 RVA: 0x00065FC7 File Offset: 0x000641C7
		public FRigControlValueStorage FloatStorage
		{
			get
			{
				base.FastCheckIsValid();
				FRigControlValueStorage result;
				if ((result = this._FloatStorage) == null)
				{
					result = (this._FloatStorage = new FRigControlValueStorage(base.NativePtr + (IntPtr)FRigControlValue.__PropertyOffset_FloatStorage, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigControlValueStorage.StaticStruct(), base.NativePtr + (IntPtr)FRigControlValue.__PropertyOffset_FloatStorage, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x0600446D RID: 17517 RVA: 0x00065FE8 File Offset: 0x000641E8
		// (set) Token: 0x0600446E RID: 17518 RVA: 0x00065FFC File Offset: 0x000641FC
		public unsafe FTransform Storage_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigControlValue.__PropertyOffset_Storage_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigControlValue.__PropertyOffset_Storage_DEPRECATED) = value;
			}
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x00066011 File Offset: 0x00064211
		public FRigControlValue()
		{
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x00066019 File Offset: 0x00064219
		public FRigControlValue(FRigControlValueStorage FloatStorage, FTransform Storage_DEPRECATED)
		{
			this.FloatStorage = FloatStorage;
			this.Storage_DEPRECATED = Storage_DEPRECATED;
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x0006602F File Offset: 0x0006422F
		protected override IntPtr GetUStructPtr()
		{
			return FRigControlValue.StaticStruct();
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x0006603B File Offset: 0x0006423B
		[NullableContext(2)]
		public FRigControlValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x00066045 File Offset: 0x00064245
		public FRigControlValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00066050 File Offset: 0x00064250
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigControlValue(Pointer, false, true);
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x0006605A File Offset: 0x0006425A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigControlValue(Pointer, MemoryOwner);
		}

		// Token: 0x0400215A RID: 8538
		public const string __ObjectPath = "/Script/ControlRig.RigControlValue";

		// Token: 0x0400215B RID: 8539
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400215C RID: 8540
		internal static int __PropertyOffset_FloatStorage;

		// Token: 0x0400215D RID: 8541
		[Nullable(2)]
		private FRigControlValueStorage _FloatStorage;

		// Token: 0x0400215E RID: 8542
		internal static int __PropertyOffset_Storage_DEPRECATED;
	}
}
