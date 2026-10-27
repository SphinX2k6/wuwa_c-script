using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002742 RID: 10050
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestStruct_Interface")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FSharpherealTestStruct_Interface : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060253DC RID: 152540 RVA: 0x003739A8 File Offset: 0x00371BA8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSharpherealTestStruct_Interface._ScriptStructPtr != 0) ? FSharpherealTestStruct_Interface._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SharpherealTest.SharpherealTestStruct_Interface", ref FSharpherealTestStruct_Interface._ScriptStructPtr);
		}

		// Token: 0x17008FCF RID: 36815
		// (get) Token: 0x060253DD RID: 152541 RVA: 0x003739CC File Offset: 0x00371BCC
		// (set) Token: 0x060253DE RID: 152542 RVA: 0x003739E0 File Offset: 0x00371BE0
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

		// Token: 0x17008FD0 RID: 36816
		// (get) Token: 0x060253DF RID: 152543 RVA: 0x003739F5 File Offset: 0x00371BF5
		// (set) Token: 0x060253E0 RID: 152544 RVA: 0x00373A0F File Offset: 0x00371C0F
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

		// Token: 0x17008FD1 RID: 36817
		// (get) Token: 0x060253E1 RID: 152545 RVA: 0x00373A35 File Offset: 0x00371C35
		// (set) Token: 0x060253E2 RID: 152546 RVA: 0x00373A4F File Offset: 0x00371C4F
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

		// Token: 0x17008FD2 RID: 36818
		// (get) Token: 0x060253E3 RID: 152547 RVA: 0x00373A78 File Offset: 0x00371C78
		// (set) Token: 0x060253E4 RID: 152548 RVA: 0x00373ABB File Offset: 0x00371CBB
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

		// Token: 0x17008FD3 RID: 36819
		// (get) Token: 0x060253E5 RID: 152549 RVA: 0x00373ACC File Offset: 0x00371CCC
		// (set) Token: 0x060253E6 RID: 152550 RVA: 0x00373B0F File Offset: 0x00371D0F
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

		// Token: 0x17008FD4 RID: 36820
		// (get) Token: 0x060253E7 RID: 152551 RVA: 0x00373B20 File Offset: 0x00371D20
		// (set) Token: 0x060253E8 RID: 152552 RVA: 0x00373B63 File Offset: 0x00371D63
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

		// Token: 0x17008FD5 RID: 36821
		// (get) Token: 0x060253E9 RID: 152553 RVA: 0x00373B74 File Offset: 0x00371D74
		// (set) Token: 0x060253EA RID: 152554 RVA: 0x00373BB8 File Offset: 0x00371DB8
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

		// Token: 0x17008FD6 RID: 36822
		// (get) Token: 0x060253EB RID: 152555 RVA: 0x00373BC8 File Offset: 0x00371DC8
		// (set) Token: 0x060253EC RID: 152556 RVA: 0x00373C0C File Offset: 0x00371E0C
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

		// Token: 0x17008FD7 RID: 36823
		// (get) Token: 0x060253ED RID: 152557 RVA: 0x00373C1C File Offset: 0x00371E1C
		// (set) Token: 0x060253EE RID: 152558 RVA: 0x00373C60 File Offset: 0x00371E60
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

		// Token: 0x060253EF RID: 152559 RVA: 0x00373C6E File Offset: 0x00371E6E
		public FSharpherealTestStruct_Interface()
		{
		}

		// Token: 0x060253F0 RID: 152560 RVA: 0x00373C78 File Offset: 0x00371E78
		public FSharpherealTestStruct_Interface(FScriptInterface ScriptInterface, ISharpherealTestInterface Interface, ISharpherealTestInterface2 Interface2, TArray<FScriptInterface> ScriptInterfaceArray, TArray<ISharpherealTestInterface> InterfaceArray, TArray<ISharpherealTestInterface2> Interface2Array, TFixedArray<FScriptInterface> ScriptInterfaceFixedArray, TFixedArray<ISharpherealTestInterface> InterfaceFixedArray, TFixedArray<ISharpherealTestInterface2> Interface2FixedArray)
		{
			this.ScriptInterface = ScriptInterface;
			this.Interface = Interface;
			this.Interface2 = Interface2;
			this.ScriptInterfaceArray = ScriptInterfaceArray;
			this.InterfaceArray = InterfaceArray;
			this.Interface2Array = Interface2Array;
			this.ScriptInterfaceFixedArray = ScriptInterfaceFixedArray;
			this.InterfaceFixedArray = InterfaceFixedArray;
			this.Interface2FixedArray = Interface2FixedArray;
		}

		// Token: 0x060253F1 RID: 152561 RVA: 0x00373CD0 File Offset: 0x00371ED0
		protected override IntPtr GetUStructPtr()
		{
			return FSharpherealTestStruct_Interface.StaticStruct();
		}

		// Token: 0x060253F2 RID: 152562 RVA: 0x00373CDC File Offset: 0x00371EDC
		[NullableContext(2)]
		public FSharpherealTestStruct_Interface(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060253F3 RID: 152563 RVA: 0x00373CE6 File Offset: 0x00371EE6
		public FSharpherealTestStruct_Interface(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060253F4 RID: 152564 RVA: 0x00373CF1 File Offset: 0x00371EF1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSharpherealTestStruct_Interface(Pointer, false, true);
		}

		// Token: 0x060253F5 RID: 152565 RVA: 0x00373CFB File Offset: 0x00371EFB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSharpherealTestStruct_Interface(Pointer, MemoryOwner);
		}

		// Token: 0x04014165 RID: 82277
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestStruct_Interface";

		// Token: 0x04014166 RID: 82278
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014167 RID: 82279
		internal static int __PropertyOffset_ScriptInterface;

		// Token: 0x04014168 RID: 82280
		internal static int __PropertyOffset_Interface;

		// Token: 0x04014169 RID: 82281
		internal static int __PropertyOffset_Interface2;

		// Token: 0x0401416A RID: 82282
		internal static int __PropertyOffset_ScriptInterfaceArray;

		// Token: 0x0401416B RID: 82283
		[Nullable(2)]
		private TArray<FScriptInterface> _ScriptInterfaceArray;

		// Token: 0x0401416C RID: 82284
		internal static int __PropertyOffset_InterfaceArray;

		// Token: 0x0401416D RID: 82285
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface> _InterfaceArray;

		// Token: 0x0401416E RID: 82286
		internal static int __PropertyOffset_Interface2Array;

		// Token: 0x0401416F RID: 82287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ISharpherealTestInterface2> _Interface2Array;

		// Token: 0x04014170 RID: 82288
		internal static int __PropertyOffset_ScriptInterfaceFixedArray;

		// Token: 0x04014171 RID: 82289
		[Nullable(2)]
		private TFixedArray<FScriptInterface> _ScriptInterfaceFixedArray;

		// Token: 0x04014172 RID: 82290
		internal static int __PropertyOffset_InterfaceFixedArray;

		// Token: 0x04014173 RID: 82291
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<ISharpherealTestInterface> _InterfaceFixedArray;

		// Token: 0x04014174 RID: 82292
		internal static int __PropertyOffset_Interface2FixedArray;

		// Token: 0x04014175 RID: 82293
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<ISharpherealTestInterface2> _Interface2FixedArray;
	}
}
