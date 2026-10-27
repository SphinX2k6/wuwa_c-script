using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013D7 RID: 5079
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.EditableGameplayTagQueryExpression_NoExprMatch")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UEditableGameplayTagQueryExpression_NoExprMatch : UEditableGameplayTagQueryExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012972 RID: 76146 RVA: 0x001B5A35 File Offset: 0x001B3C35
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableGameplayTagQueryExpression_NoExprMatch._ClassPtr;
		}

		// Token: 0x06012973 RID: 76147 RVA: 0x001B5A44 File Offset: 0x001B3C44
		public UEditableGameplayTagQueryExpression_NoExprMatch() : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_NoExprMatch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012974 RID: 76148 RVA: 0x001B5A6C File Offset: 0x001B3C6C
		public UEditableGameplayTagQueryExpression_NoExprMatch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_NoExprMatch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x06012975 RID: 76149 RVA: 0x001B5AA0 File Offset: 0x001B3CA0
		// (set) Token: 0x06012976 RID: 76150 RVA: 0x001B5AD9 File Offset: 0x001B3CD9
		public TArray<UEditableGameplayTagQueryExpression> Expressions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEditableGameplayTagQueryExpression> result;
				if ((result = this._Expressions) == null)
				{
					result = (this._Expressions = new TArray<UEditableGameplayTagQueryExpression>(base.NativePtr + (IntPtr)UEditableGameplayTagQueryExpression_NoExprMatch.__PropertyOffset_Expressions, this));
				}
				return result;
			}
			set
			{
				this.Expressions.CopyAssign(value);
			}
		}

		// Token: 0x06012977 RID: 76151 RVA: 0x001B5AE7 File Offset: 0x001B3CE7
		static UEditableGameplayTagQueryExpression_NoExprMatch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.EditableGameplayTagQueryExpression_NoExprMatch");
		}

		// Token: 0x06012978 RID: 76152 RVA: 0x001B5AF5 File Offset: 0x001B3CF5
		protected UEditableGameplayTagQueryExpression_NoExprMatch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009EE4 RID: 40676
		public new const string __ObjectPath = "/Script/GameplayTags.EditableGameplayTagQueryExpression_NoExprMatch";

		// Token: 0x04009EE5 RID: 40677
		private static IntPtr _ClassPtr;

		// Token: 0x04009EE6 RID: 40678
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009EE7 RID: 40679
		internal static int __PropertyOffset_Expressions;

		// Token: 0x04009EE8 RID: 40680
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEditableGameplayTagQueryExpression> _Expressions;
	}
}
