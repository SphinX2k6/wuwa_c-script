using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007F6 RID: 2038
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_Interface")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FSharpherealTestStruct_Interface : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AEBD RID: 44733 RVA: 0x001035C9 File Offset: 0x001017C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_Interface._ScriptStructPtr != 0) ? FSharpherealTestStruct_Interface._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_Interface", ref FSharpherealTestStruct_Interface._ScriptStructPtr);
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x0600AEBE RID: 44734 RVA: 0x001035ED File Offset: 0x001017ED
		// (set) Token: 0x0600AEBF RID: 44735 RVA: 0x00103601 File Offset: 0x00101801
		public unsafe FScriptInterface ScriptInterface
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_ScriptInterface);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_ScriptInterface) = value;
			}
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x0600AEC0 RID: 44736 RVA: 0x00103616 File Offset: 0x00101816
		// (set) Token: 0x0600AEC1 RID: 44737 RVA: 0x00103630 File Offset: 0x00101830
		[Nullable(2)]
		public unsafe ISharpherealTestInterface Interface
		{
			[NullableContext(2)]
			get
			{
				return (ISharpherealTestInterface)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_Interface));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_Interface) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x170020B9 RID: 8377
		// (get) Token: 0x0600AEC2 RID: 44738 RVA: 0x00103656 File Offset: 0x00101856
		// (set) Token: 0x0600AEC3 RID: 44739 RVA: 0x00103670 File Offset: 0x00101870
		[Nullable(2)]
		public unsafe ISharpherealTestInterface2 Interface2
		{
			[NullableContext(2)]
			get
			{
				return (ISharpherealTestInterface2)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_Interface2));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_Interface2) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x0600AEC4 RID: 44740 RVA: 0x00103698 File Offset: 0x00101898
		// (set) Token: 0x0600AEC5 RID: 44741 RVA: 0x001036DB File Offset: 0x001018DB
		public TArray<FScriptInterface> ScriptInterfaceArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FScriptInterface> result;
				if ((result = this._ScriptInterfaceArray) == null)
				{
					result = (this._ScriptInterfaceArray = new TArray<FScriptInterface>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_ScriptInterfaceArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScriptInterfaceArray.CopyAssign(value);
			}
		}

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x0600AEC6 RID: 44742 RVA: 0x001036EC File Offset: 0x001018EC
		// (set) Token: 0x0600AEC7 RID: 44743 RVA: 0x0010372F File Offset: 0x0010192F
		public TArray<ISharpherealTestInterface> InterfaceArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ISharpherealTestInterface> result;
				if ((result = this._InterfaceArray) == null)
				{
					result = (this._InterfaceArray = new TArray<ISharpherealTestInterface>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_InterfaceArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InterfaceArray.CopyAssign(value);
			}
		}

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x0600AEC8 RID: 44744 RVA: 0x00103740 File Offset: 0x00101940
		// (set) Token: 0x0600AEC9 RID: 44745 RVA: 0x00103783 File Offset: 0x00101983
		public TArray<ISharpherealTestInterface2> Interface2Array
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ISharpherealTestInterface2> result;
				if ((result = this._Interface2Array) == null)
				{
					result = (this._Interface2Array = new TArray<ISharpherealTestInterface2>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_Interface2Array, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Interface2Array.CopyAssign(value);
			}
		}

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x0600AECA RID: 44746 RVA: 0x00103794 File Offset: 0x00101994
		// (set) Token: 0x0600AECB RID: 44747 RVA: 0x001037D8 File Offset: 0x001019D8
		public TFixedArray<FScriptInterface> ScriptInterfaceFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FScriptInterface> result;
				if ((result = this._ScriptInterfaceFixedArray) == null)
				{
					result = (this._ScriptInterfaceFixedArray = new TFixedArray<FScriptInterface>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_ScriptInterfaceFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScriptInterfaceFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x170020BE RID: 8382
		// (get) Token: 0x0600AECC RID: 44748 RVA: 0x001037E8 File Offset: 0x001019E8
		// (set) Token: 0x0600AECD RID: 44749 RVA: 0x0010382C File Offset: 0x00101A2C
		public TFixedArray<ISharpherealTestInterface> InterfaceFixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<ISharpherealTestInterface> result;
				if ((result = this._InterfaceFixedArray) == null)
				{
					result = (this._InterfaceFixedArray = new TFixedArray<ISharpherealTestInterface>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_InterfaceFixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InterfaceFixedArray.CopyAssign(value);
			}
		}

		// Token: 0x170020BF RID: 8383
		// (get) Token: 0x0600AECE RID: 44750 RVA: 0x0010383C File Offset: 0x00101A3C
		// (set) Token: 0x0600AECF RID: 44751 RVA: 0x00103880 File Offset: 0x00101A80
		public TFixedArray<ISharpherealTestInterface2> Interface2FixedArray
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<ISharpherealTestInterface2> result;
				if ((result = this._Interface2FixedArray) == null)
				{
					result = (this._Interface2FixedArray = new TFixedArray<ISharpherealTestInterface2>(base.NativePtr + (IntPtr)FSharpherealTestStruct_Interface.__PropertyOffset_Interface2FixedArray, 2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Interface2FixedArray.CopyAssign(value);
			}
		}

		// Token: 0x0600AED0 RID: 44752 RVA: 0x0010388E File Offset: 0x00101A8E
		public FSharpherealTestStruct_Interface()
		{
		}

		// Token: 0x0600AED1 RID: 44753 RVA: 0x00103896 File Offset: 0x00101A96
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_Interface.StaticStruct();
		}

		// Token: 0x0600AED2 RID: 44754 RVA: 0x001038A2 File Offset: 0x00101AA2
		[NullableContext(2)]
		public FSharpherealTestStruct_Interface(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AED3 RID: 44755 RVA: 0x001038AC File Offset: 0x00101AAC
		public FSharpherealTestStruct_Interface(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AED4 RID: 44756 RVA: 0x001038B7 File Offset: 0x00101AB7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_Interface(Pointer, false, true);
		}

		// Token: 0x0600AED5 RID: 44757 RVA: 0x001038C1 File Offset: 0x00101AC1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_Interface(Pointer, MemoryOwner);
		}

		// Token: 0x04004BC4 RID: 19396
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_Interface";

		// Token: 0x04004BC5 RID: 19397
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004BC6 RID: 19398
		internal static int __PropertyOffset_ScriptInterface;

		// Token: 0x04004BC7 RID: 19399
		internal static int __PropertyOffset_Interface;

		// Token: 0x04004BC8 RID: 19400
		internal static int __PropertyOffset_Interface2;

		// Token: 0x04004BC9 RID: 19401
		internal static int __PropertyOffset_ScriptInterfaceArray;

		// Token: 0x04004BCA RID: 19402
		[Nullable(2)]
		private TArray<FScriptInterface> _ScriptInterfaceArray;

		// Token: 0x04004BCB RID: 19403
		internal static int __PropertyOffset_InterfaceArray;

		// Token: 0x04004BCC RID: 19404
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface> _InterfaceArray;

		// Token: 0x04004BCD RID: 19405
		internal static int __PropertyOffset_Interface2Array;

		// Token: 0x04004BCE RID: 19406
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface2> _Interface2Array;

		// Token: 0x04004BCF RID: 19407
		internal static int __PropertyOffset_ScriptInterfaceFixedArray;

		// Token: 0x04004BD0 RID: 19408
		[Nullable(2)]
		private TFixedArray<FScriptInterface> _ScriptInterfaceFixedArray;

		// Token: 0x04004BD1 RID: 19409
		internal static int __PropertyOffset_InterfaceFixedArray;

		// Token: 0x04004BD2 RID: 19410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<ISharpherealTestInterface> _InterfaceFixedArray;

		// Token: 0x04004BD3 RID: 19411
		internal static int __PropertyOffset_Interface2FixedArray;

		// Token: 0x04004BD4 RID: 19412
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<ISharpherealTestInterface2> _Interface2FixedArray;
	}
}
