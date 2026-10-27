using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013D5 RID: 5077
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.EditableGameplayTagQueryExpression_AnyExprMatch")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UEditableGameplayTagQueryExpression_AnyExprMatch : UEditableGameplayTagQueryExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012964 RID: 76132 RVA: 0x001B5891 File Offset: 0x001B3A91
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableGameplayTagQueryExpression_AnyExprMatch._ClassPtr;
		}

		// Token: 0x06012965 RID: 76133 RVA: 0x001B58A0 File Offset: 0x001B3AA0
		public UEditableGameplayTagQueryExpression_AnyExprMatch() : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_AnyExprMatch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012966 RID: 76134 RVA: 0x001B58C8 File Offset: 0x001B3AC8
		public UEditableGameplayTagQueryExpression_AnyExprMatch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_AnyExprMatch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x06012967 RID: 76135 RVA: 0x001B58FC File Offset: 0x001B3AFC
		// (set) Token: 0x06012968 RID: 76136 RVA: 0x001B5935 File Offset: 0x001B3B35
		public TArray<UEditableGameplayTagQueryExpression> Expressions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEditableGameplayTagQueryExpression> result;
				if ((result = this._Expressions) == null)
				{
					result = (this._Expressions = new TArray<UEditableGameplayTagQueryExpression>(base.NativePtr + (IntPtr)UEditableGameplayTagQueryExpression_AnyExprMatch.__PropertyOffset_Expressions, this));
				}
				return result;
			}
			set
			{
				this.Expressions.CopyAssign(value);
			}
		}

		// Token: 0x06012969 RID: 76137 RVA: 0x001B5943 File Offset: 0x001B3B43
		static UEditableGameplayTagQueryExpression_AnyExprMatch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.EditableGameplayTagQueryExpression_AnyExprMatch");
		}

		// Token: 0x0601296A RID: 76138 RVA: 0x001B5951 File Offset: 0x001B3B51
		protected UEditableGameplayTagQueryExpression_AnyExprMatch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009EDA RID: 40666
		public new const string __ObjectPath = "/Script/GameplayTags.EditableGameplayTagQueryExpression_AnyExprMatch";

		// Token: 0x04009EDB RID: 40667
		private static IntPtr _ClassPtr;

		// Token: 0x04009EDC RID: 40668
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009EDD RID: 40669
		internal static int __PropertyOffset_Expressions;

		// Token: 0x04009EDE RID: 40670
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEditableGameplayTagQueryExpression> _Expressions;
	}
}
