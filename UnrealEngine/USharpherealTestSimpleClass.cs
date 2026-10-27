using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002738 RID: 10040
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestSimpleClass")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class USharpherealTestSimpleClass : UObject, IUnrealUObject, IUnrealObject, ISharpherealTestInterface, IUnrealNativeInterface, IUnrealInterface, ISharpherealTestInterface2
	{
		// Token: 0x060252B9 RID: 152249 RVA: 0x0037108E File Offset: 0x0036F28E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USharpherealTestSimpleClass._ClassPtr;
		}

		// Token: 0x060252BA RID: 152250 RVA: 0x0037109A File Offset: 0x0036F29A
		int ISharpherealTestInterface.InterfaceOffset()
		{
			return USharpherealTestSimpleClass.__InterfaceOffset_ISharpherealTestInterface;
		}

		// Token: 0x060252BB RID: 152251 RVA: 0x003710A1 File Offset: 0x0036F2A1
		int ISharpherealTestInterface2.InterfaceOffset()
		{
			return USharpherealTestSimpleClass.__InterfaceOffset_ISharpherealTestInterface2;
		}

		// Token: 0x060252BC RID: 152252 RVA: 0x003710A8 File Offset: 0x0036F2A8
		public USharpherealTestSimpleClass() : this(BuiltinUtils.AllocNativeUObject(USharpherealTestSimpleClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060252BD RID: 152253 RVA: 0x003710D0 File Offset: 0x0036F2D0
		[NullableContext(1)]
		public USharpherealTestSimpleClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USharpherealTestSimpleClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008F67 RID: 36711
		// (get) Token: 0x060252BE RID: 152254 RVA: 0x00371103 File Offset: 0x0036F303
		// (set) Token: 0x060252BF RID: 152255 RVA: 0x00371117 File Offset: 0x0036F317
		public unsafe FVector Vector
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USharpherealTestSimpleClass.__PropertyOffset_Vector);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USharpherealTestSimpleClass.__PropertyOffset_Vector) = value;
			}
		}

		// Token: 0x17008F68 RID: 36712
		// (get) Token: 0x060252C0 RID: 152256 RVA: 0x0037112C File Offset: 0x0036F32C
		// (set) Token: 0x060252C1 RID: 152257 RVA: 0x00371140 File Offset: 0x0036F340
		[Nullable(1)]
		public unsafe string String
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)USharpherealTestSimpleClass.__PropertyOffset_String)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)USharpherealTestSimpleClass.__PropertyOffset_String)), value);
			}
		}

		// Token: 0x060252C2 RID: 152258 RVA: 0x00371155 File Offset: 0x0036F355
		static USharpherealTestSimpleClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SharpherealTest.SharpherealTestSimpleClass");
		}

		// Token: 0x060252C3 RID: 152259 RVA: 0x00371163 File Offset: 0x0036F363
		protected USharpherealTestSimpleClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014088 RID: 82056
		internal static int __InterfaceOffset_ISharpherealTestInterface;

		// Token: 0x04014089 RID: 82057
		internal static int __InterfaceOffset_ISharpherealTestInterface2;

		// Token: 0x0401408A RID: 82058
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestSimpleClass";

		// Token: 0x0401408B RID: 82059
		private static IntPtr _ClassPtr;

		// Token: 0x0401408C RID: 82060
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401408D RID: 82061
		internal static int __PropertyOffset_Vector;

		// Token: 0x0401408E RID: 82062
		internal static int __PropertyOffset_String;
	}
}
