using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C7B RID: 3195
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpFilter")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UInterpFilter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A24E RID: 41550 RVA: 0x000E66EF File Offset: 0x000E48EF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpFilter._ClassPtr;
		}

		// Token: 0x0600A24F RID: 41551 RVA: 0x000E66FC File Offset: 0x000E48FC
		public UInterpFilter() : this(BuiltinUtils.AllocNativeUObject(UInterpFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A250 RID: 41552 RVA: 0x000E6724 File Offset: 0x000E4924
		public UInterpFilter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpFilter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026A3 RID: 9891
		// (get) Token: 0x0600A251 RID: 41553 RVA: 0x000E6757 File Offset: 0x000E4957
		// (set) Token: 0x0600A252 RID: 41554 RVA: 0x000E676B File Offset: 0x000E496B
		public unsafe string Caption
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UInterpFilter.__PropertyOffset_Caption)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UInterpFilter.__PropertyOffset_Caption)), value);
			}
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x000E6780 File Offset: 0x000E4980
		static UInterpFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpFilter");
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x000E678E File Offset: 0x000E498E
		protected UInterpFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400590E RID: 22798
		public new const string __ObjectPath = "/Script/Engine.InterpFilter";

		// Token: 0x0400590F RID: 22799
		private static IntPtr _ClassPtr;

		// Token: 0x04005910 RID: 22800
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005911 RID: 22801
		internal static int __PropertyOffset_Caption;
	}
}
