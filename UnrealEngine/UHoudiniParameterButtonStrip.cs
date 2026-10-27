using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014EA RID: 5354
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterButtonStrip")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UHoudiniParameterButtonStrip : UHoudiniParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601365F RID: 79455 RVA: 0x001C853A File Offset: 0x001C673A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterButtonStrip._ClassPtr;
		}

		// Token: 0x06013660 RID: 79456 RVA: 0x001C8548 File Offset: 0x001C6748
		public UHoudiniParameterButtonStrip() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterButtonStrip.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013661 RID: 79457 RVA: 0x001C8570 File Offset: 0x001C6770
		public UHoudiniParameterButtonStrip(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterButtonStrip.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BB2 RID: 19378
		// (get) Token: 0x06013662 RID: 79458 RVA: 0x001C85A3 File Offset: 0x001C67A3
		// (set) Token: 0x06013663 RID: 79459 RVA: 0x001C85B3 File Offset: 0x001C67B3
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterButtonStrip.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterButtonStrip.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x17004BB3 RID: 19379
		// (get) Token: 0x06013664 RID: 79460 RVA: 0x001C85C4 File Offset: 0x001C67C4
		// (set) Token: 0x06013665 RID: 79461 RVA: 0x001C85FD File Offset: 0x001C67FD
		public TArray<string> Labels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Labels) == null)
				{
					result = (this._Labels = new TArray<string>(base.NativePtr + (IntPtr)UHoudiniParameterButtonStrip.__PropertyOffset_Labels, this));
				}
				return result;
			}
			set
			{
				this.Labels.CopyAssign(value);
			}
		}

		// Token: 0x17004BB4 RID: 19380
		// (get) Token: 0x06013666 RID: 79462 RVA: 0x001C860C File Offset: 0x001C680C
		// (set) Token: 0x06013667 RID: 79463 RVA: 0x001C8645 File Offset: 0x001C6845
		public TArray<int> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniParameterButtonStrip.__PropertyOffset_Values, this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x06013668 RID: 79464 RVA: 0x001C8653 File Offset: 0x001C6853
		static UHoudiniParameterButtonStrip()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterButtonStrip");
		}

		// Token: 0x06013669 RID: 79465 RVA: 0x001C8661 File Offset: 0x001C6861
		protected UHoudiniParameterButtonStrip(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A7AF RID: 42927
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterButtonStrip";

		// Token: 0x0400A7B0 RID: 42928
		private static IntPtr _ClassPtr;

		// Token: 0x0400A7B1 RID: 42929
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A7B2 RID: 42930
		internal static int __PropertyOffset_Count;

		// Token: 0x0400A7B3 RID: 42931
		internal static int __PropertyOffset_Labels;

		// Token: 0x0400A7B4 RID: 42932
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Labels;

		// Token: 0x0400A7B5 RID: 42933
		internal static int __PropertyOffset_Values;

		// Token: 0x0400A7B6 RID: 42934
		[Nullable(2)]
		private TArray<int> _Values;
	}
}
