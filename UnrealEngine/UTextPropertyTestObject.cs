using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011C8 RID: 4552
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.TextPropertyTestObject")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UTextPropertyTestObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010C4A RID: 68682 RVA: 0x0018A0BB File Offset: 0x001882BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTextPropertyTestObject._ClassPtr;
		}

		// Token: 0x06010C4B RID: 68683 RVA: 0x0018A0C8 File Offset: 0x001882C8
		public UTextPropertyTestObject() : this(BuiltinUtils.AllocNativeUObject(UTextPropertyTestObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010C4C RID: 68684 RVA: 0x0018A0F0 File Offset: 0x001882F0
		public UTextPropertyTestObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTextPropertyTestObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004173 RID: 16755
		// (get) Token: 0x06010C4D RID: 68685 RVA: 0x0018A124 File Offset: 0x00188324
		// (set) Token: 0x06010C4E RID: 68686 RVA: 0x0018A15D File Offset: 0x0018835D
		public unsafe FText DefaultedText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DefaultedText) == null)
				{
					result = (this._DefaultedText = new FText(base.NativePtr + (IntPtr)UTextPropertyTestObject.__PropertyOffset_DefaultedText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UTextPropertyTestObject.__PropertyOffset_DefaultedText)), value.NativePtr, 1);
			}
		}

		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x06010C4F RID: 68687 RVA: 0x0018A178 File Offset: 0x00188378
		// (set) Token: 0x06010C50 RID: 68688 RVA: 0x0018A1B1 File Offset: 0x001883B1
		public unsafe FText UndefaultedText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._UndefaultedText) == null)
				{
					result = (this._UndefaultedText = new FText(base.NativePtr + (IntPtr)UTextPropertyTestObject.__PropertyOffset_UndefaultedText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UTextPropertyTestObject.__PropertyOffset_UndefaultedText)), value.NativePtr, 1);
			}
		}

		// Token: 0x17004175 RID: 16757
		// (get) Token: 0x06010C51 RID: 68689 RVA: 0x0018A1CC File Offset: 0x001883CC
		// (set) Token: 0x06010C52 RID: 68690 RVA: 0x0018A205 File Offset: 0x00188405
		public unsafe FText TransientText
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._TransientText) == null)
				{
					result = (this._TransientText = new FText(base.NativePtr + (IntPtr)UTextPropertyTestObject.__PropertyOffset_TransientText, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UTextPropertyTestObject.__PropertyOffset_TransientText)), value.NativePtr, 1);
			}
		}

		// Token: 0x06010C53 RID: 68691 RVA: 0x0018A220 File Offset: 0x00188420
		static UTextPropertyTestObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TextPropertyTestObject");
		}

		// Token: 0x06010C54 RID: 68692 RVA: 0x0018A22E File Offset: 0x0018842E
		protected UTextPropertyTestObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008F60 RID: 36704
		public new const string __ObjectPath = "/Script/Engine.TextPropertyTestObject";

		// Token: 0x04008F61 RID: 36705
		private static IntPtr _ClassPtr;

		// Token: 0x04008F62 RID: 36706
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008F63 RID: 36707
		internal static int __PropertyOffset_DefaultedText;

		// Token: 0x04008F64 RID: 36708
		[Nullable(2)]
		private FText _DefaultedText;

		// Token: 0x04008F65 RID: 36709
		internal static int __PropertyOffset_UndefaultedText;

		// Token: 0x04008F66 RID: 36710
		[Nullable(2)]
		private FText _UndefaultedText;

		// Token: 0x04008F67 RID: 36711
		internal static int __PropertyOffset_TransientText;

		// Token: 0x04008F68 RID: 36712
		[Nullable(2)]
		private FText _TransientText;
	}
}
