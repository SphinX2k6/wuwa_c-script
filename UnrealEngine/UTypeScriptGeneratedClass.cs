using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015BC RID: 5564
	[UnrealObjectPath("/Script/JsEnv.TypeScriptGeneratedClass")]
	[UnrealStructLayout(1624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1624)]
	public class UTypeScriptGeneratedClass : UBlueprintGeneratedClass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601413A RID: 82234 RVA: 0x001D77AE File Offset: 0x001D59AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTypeScriptGeneratedClass._ClassPtr;
		}

		// Token: 0x0601413B RID: 82235 RVA: 0x001D77BC File Offset: 0x001D59BC
		public UTypeScriptGeneratedClass() : this(BuiltinUtils.AllocNativeUObject(UTypeScriptGeneratedClass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601413C RID: 82236 RVA: 0x001D77E4 File Offset: 0x001D59E4
		[NullableContext(1)]
		public UTypeScriptGeneratedClass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTypeScriptGeneratedClass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004EAF RID: 20143
		// (get) Token: 0x0601413D RID: 82237 RVA: 0x001D7817 File Offset: 0x001D5A17
		// (set) Token: 0x0601413E RID: 82238 RVA: 0x001D7827 File Offset: 0x001D5A27
		public unsafe bool HasConstructor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTypeScriptGeneratedClass.__PropertyOffset_HasConstructor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTypeScriptGeneratedClass.__PropertyOffset_HasConstructor) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601413F RID: 82239 RVA: 0x001D7838 File Offset: 0x001D5A38
		static UTypeScriptGeneratedClass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/JsEnv.TypeScriptGeneratedClass");
		}

		// Token: 0x06014140 RID: 82240 RVA: 0x001D7846 File Offset: 0x001D5A46
		protected UTypeScriptGeneratedClass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AEA1 RID: 44705
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/JsEnv.TypeScriptGeneratedClass";

		// Token: 0x0400AEA2 RID: 44706
		private static IntPtr _ClassPtr;

		// Token: 0x0400AEA3 RID: 44707
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400AEA4 RID: 44708
		internal static int __PropertyOffset_HasConstructor;
	}
}
