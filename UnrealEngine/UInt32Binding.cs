using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200297B RID: 10619
	[UnrealObjectPath("/Script/UMG.Int32Binding")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UInt32Binding : UPropertyBinding, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602749D RID: 160925 RVA: 0x003BE918 File Offset: 0x003BCB18
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInt32Binding._ClassPtr;
		}

		// Token: 0x0602749E RID: 160926 RVA: 0x003BE924 File Offset: 0x003BCB24
		public UInt32Binding() : this(BuiltinUtils.AllocNativeUObject(UInt32Binding.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602749F RID: 160927 RVA: 0x003BE94C File Offset: 0x003BCB4C
		[NullableContext(1)]
		public UInt32Binding(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInt32Binding.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060274A0 RID: 160928 RVA: 0x003BE97F File Offset: 0x003BCB7F
		public int GetValue()
		{
			return UInt32Binding.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x060274A1 RID: 160929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetValue_Internal(IntPtr @this);

		// Token: 0x060274A2 RID: 160930 RVA: 0x003BE98C File Offset: 0x003BCB8C
		static UInt32Binding()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Int32Binding");
		}

		// Token: 0x060274A3 RID: 160931 RVA: 0x003BE99A File Offset: 0x003BCB9A
		protected UInt32Binding(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401594B RID: 88395
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.Int32Binding";

		// Token: 0x0401594C RID: 88396
		private static IntPtr _ClassPtr;

		// Token: 0x0401594D RID: 88397
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
