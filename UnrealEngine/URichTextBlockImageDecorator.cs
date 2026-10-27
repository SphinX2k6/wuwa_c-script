using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029CA RID: 10698
	[UnrealObjectPath("/Script/UMG.RichTextBlockImageDecorator")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class URichTextBlockImageDecorator : URichTextBlockDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060278D3 RID: 162003 RVA: 0x003C588D File Offset: 0x003C3A8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URichTextBlockImageDecorator._ClassPtr;
		}

		// Token: 0x1700978F RID: 38799
		// (get) Token: 0x060278D4 RID: 162004 RVA: 0x003C5899 File Offset: 0x003C3A99
		// (set) Token: 0x060278D5 RID: 162005 RVA: 0x003C58AD File Offset: 0x003C3AAD
		[Nullable(2)]
		public unsafe UDataTable ImageSet
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + URichTextBlockImageDecorator.__PropertyOffset_ImageSet);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + URichTextBlockImageDecorator.__PropertyOffset_ImageSet, value);
			}
		}

		// Token: 0x060278D6 RID: 162006 RVA: 0x003C58C2 File Offset: 0x003C3AC2
		static URichTextBlockImageDecorator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.RichTextBlockImageDecorator");
		}

		// Token: 0x060278D7 RID: 162007 RVA: 0x003C58D0 File Offset: 0x003C3AD0
		protected URichTextBlockImageDecorator() : this(BuiltinUtils.AllocNativeUObject(URichTextBlockImageDecorator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060278D8 RID: 162008 RVA: 0x003C58F8 File Offset: 0x003C3AF8
		protected URichTextBlockImageDecorator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015AE3 RID: 88803
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.RichTextBlockImageDecorator";

		// Token: 0x04015AE4 RID: 88804
		private static IntPtr _ClassPtr;

		// Token: 0x04015AE5 RID: 88805
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015AE6 RID: 88806
		internal static int __PropertyOffset_ImageSet;
	}
}
