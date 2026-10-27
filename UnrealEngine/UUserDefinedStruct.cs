using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200121A RID: 4634
	[UnrealObjectPath("/Script/Engine.UserDefinedStruct")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UUserDefinedStruct : UScriptStruct, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060110E5 RID: 69861 RVA: 0x001906C6 File Offset: 0x0018E8C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserDefinedStruct._ClassPtr;
		}

		// Token: 0x060110E6 RID: 69862 RVA: 0x001906D4 File Offset: 0x0018E8D4
		public UUserDefinedStruct() : this(BuiltinUtils.AllocNativeUObject(UUserDefinedStruct.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060110E7 RID: 69863 RVA: 0x001906FC File Offset: 0x0018E8FC
		[NullableContext(1)]
		public UUserDefinedStruct(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUserDefinedStruct.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004293 RID: 17043
		// (get) Token: 0x060110E8 RID: 69864 RVA: 0x0019072F File Offset: 0x0018E92F
		// (set) Token: 0x060110E9 RID: 69865 RVA: 0x00190743 File Offset: 0x0018E943
		public unsafe TEnumAsByte<EUserDefinedStructureStatus> Status
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserDefinedStruct.__PropertyOffset_Status);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserDefinedStruct.__PropertyOffset_Status) = value;
			}
		}

		// Token: 0x17004294 RID: 17044
		// (get) Token: 0x060110EA RID: 69866 RVA: 0x00190758 File Offset: 0x0018E958
		// (set) Token: 0x060110EB RID: 69867 RVA: 0x0019076C File Offset: 0x0018E96C
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserDefinedStruct.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserDefinedStruct.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x060110EC RID: 69868 RVA: 0x00190781 File Offset: 0x0018E981
		static UUserDefinedStruct()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.UserDefinedStruct");
		}

		// Token: 0x060110ED RID: 69869 RVA: 0x0019078F File Offset: 0x0018E98F
		protected UUserDefinedStruct(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009213 RID: 37395
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.UserDefinedStruct";

		// Token: 0x04009214 RID: 37396
		private static IntPtr _ClassPtr;

		// Token: 0x04009215 RID: 37397
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009216 RID: 37398
		internal static int __PropertyOffset_Status;

		// Token: 0x04009217 RID: 37399
		internal static int __PropertyOffset_Guid;
	}
}
