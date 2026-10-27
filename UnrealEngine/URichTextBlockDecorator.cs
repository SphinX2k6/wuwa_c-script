using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029C9 RID: 10697
	[UnrealObjectPath("/Script/UMG.RichTextBlockDecorator")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class URichTextBlockDecorator : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060278CF RID: 161999 RVA: 0x003C5842 File Offset: 0x003C3A42
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URichTextBlockDecorator._ClassPtr;
		}

		// Token: 0x060278D0 RID: 162000 RVA: 0x003C584E File Offset: 0x003C3A4E
		static URichTextBlockDecorator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.RichTextBlockDecorator");
		}

		// Token: 0x060278D1 RID: 162001 RVA: 0x003C585C File Offset: 0x003C3A5C
		protected URichTextBlockDecorator() : this(BuiltinUtils.AllocNativeUObject(URichTextBlockDecorator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060278D2 RID: 162002 RVA: 0x003C5884 File Offset: 0x003C3A84
		protected URichTextBlockDecorator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015AE0 RID: 88800
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.RichTextBlockDecorator";

		// Token: 0x04015AE1 RID: 88801
		private static IntPtr _ClassPtr;

		// Token: 0x04015AE2 RID: 88802
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
