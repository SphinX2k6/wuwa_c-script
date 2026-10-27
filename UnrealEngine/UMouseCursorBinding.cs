using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002983 RID: 10627
	[UnrealObjectPath("/Script/UMG.MouseCursorBinding")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UMouseCursorBinding : UPropertyBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602756E RID: 161134 RVA: 0x003BF863 File Offset: 0x003BDA63
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMouseCursorBinding._ClassPtr;
		}

		// Token: 0x0602756F RID: 161135 RVA: 0x003BF870 File Offset: 0x003BDA70
		public UMouseCursorBinding() : this(BuiltinUtils.AllocNativeUObject(UMouseCursorBinding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027570 RID: 161136 RVA: 0x003BF898 File Offset: 0x003BDA98
		[NullableContext(1)]
		public UMouseCursorBinding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMouseCursorBinding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027571 RID: 161137 RVA: 0x003BF8CB File Offset: 0x003BDACB
		public TEnumAsByte<EMouseCursor> GetValue()
		{
			return UMouseCursorBinding.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x06027572 RID: 161138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EMouseCursor> __GetValue_Internal(IntPtr @this);

		// Token: 0x06027573 RID: 161139 RVA: 0x003BF8D8 File Offset: 0x003BDAD8
		static UMouseCursorBinding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.MouseCursorBinding");
		}

		// Token: 0x06027574 RID: 161140 RVA: 0x003BF8E6 File Offset: 0x003BDAE6
		protected UMouseCursorBinding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401599A RID: 88474
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.MouseCursorBinding";

		// Token: 0x0401599B RID: 88475
		private static IntPtr _ClassPtr;

		// Token: 0x0401599C RID: 88476
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
