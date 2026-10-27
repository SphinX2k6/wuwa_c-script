using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200272F RID: 10031
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestClass_FixedArray")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class USharpherealTestClass_FixedArray : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025270 RID: 152176 RVA: 0x0037064C File Offset: 0x0036E84C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USharpherealTestClass_FixedArray._ClassPtr;
		}

		// Token: 0x06025271 RID: 152177 RVA: 0x00370658 File Offset: 0x0036E858
		public USharpherealTestClass_FixedArray() : this(BuiltinUtils.AllocNativeUObject(USharpherealTestClass_FixedArray.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025272 RID: 152178 RVA: 0x00370680 File Offset: 0x0036E880
		public USharpherealTestClass_FixedArray(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USharpherealTestClass_FixedArray.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008F64 RID: 36708
		// (get) Token: 0x06025273 RID: 152179 RVA: 0x003706B4 File Offset: 0x0036E8B4
		// (set) Token: 0x06025274 RID: 152180 RVA: 0x003706EE File Offset: 0x0036E8EE
		public TFixedArray<FVector> V
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FVector> result;
				if ((result = this._V) == null)
				{
					result = (this._V = new TFixedArray<FVector>(base.NativePtr + (IntPtr)USharpherealTestClass_FixedArray.__PropertyOffset_V, 2, this));
				}
				return result;
			}
			set
			{
				this.V.CopyAssign(value);
			}
		}

		// Token: 0x17008F65 RID: 36709
		// (get) Token: 0x06025275 RID: 152181 RVA: 0x003706FC File Offset: 0x0036E8FC
		// (set) Token: 0x06025276 RID: 152182 RVA: 0x00370710 File Offset: 0x0036E910
		public unsafe FTransform T
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USharpherealTestClass_FixedArray.__PropertyOffset_T);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USharpherealTestClass_FixedArray.__PropertyOffset_T) = value;
			}
		}

		// Token: 0x17008F66 RID: 36710
		// (get) Token: 0x06025277 RID: 152183 RVA: 0x00370725 File Offset: 0x0036E925
		// (set) Token: 0x06025278 RID: 152184 RVA: 0x00370739 File Offset: 0x0036E939
		public unsafe string S
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USharpherealTestClass_FixedArray.__PropertyOffset_S)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USharpherealTestClass_FixedArray.__PropertyOffset_S)), value);
			}
		}

		// Token: 0x06025279 RID: 152185 RVA: 0x0037074E File Offset: 0x0036E94E
		static USharpherealTestClass_FixedArray()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.SharpherealTestClass_FixedArray");
		}

		// Token: 0x0602527A RID: 152186 RVA: 0x0037075C File Offset: 0x0036E95C
		protected USharpherealTestClass_FixedArray(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401406D RID: 82029
		public new const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestClass_FixedArray";

		// Token: 0x0401406E RID: 82030
		private static IntPtr _ClassPtr;

		// Token: 0x0401406F RID: 82031
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014070 RID: 82032
		internal static int __PropertyOffset_V;

		// Token: 0x04014071 RID: 82033
		[Nullable(2)]
		private TFixedArray<FVector> _V;

		// Token: 0x04014072 RID: 82034
		internal static int __PropertyOffset_T;

		// Token: 0x04014073 RID: 82035
		internal static int __PropertyOffset_S;
	}
}
