using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013D3 RID: 5075
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.EditableGameplayTagQueryExpression_AllExprMatch")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UEditableGameplayTagQueryExpression_AllExprMatch : UEditableGameplayTagQueryExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012956 RID: 76118 RVA: 0x001B56ED File Offset: 0x001B38ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEditableGameplayTagQueryExpression_AllExprMatch._ClassPtr;
		}

		// Token: 0x06012957 RID: 76119 RVA: 0x001B56FC File Offset: 0x001B38FC
		public UEditableGameplayTagQueryExpression_AllExprMatch() : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_AllExprMatch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012958 RID: 76120 RVA: 0x001B5724 File Offset: 0x001B3924
		public UEditableGameplayTagQueryExpression_AllExprMatch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEditableGameplayTagQueryExpression_AllExprMatch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004814 RID: 18452
		// (get) Token: 0x06012959 RID: 76121 RVA: 0x001B5758 File Offset: 0x001B3958
		// (set) Token: 0x0601295A RID: 76122 RVA: 0x001B5791 File Offset: 0x001B3991
		public TArray<UEditableGameplayTagQueryExpression> Expressions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UEditableGameplayTagQueryExpression> result;
				if ((result = this._Expressions) == null)
				{
					result = (this._Expressions = new TArray<UEditableGameplayTagQueryExpression>(base.NativePtr + (IntPtr)UEditableGameplayTagQueryExpression_AllExprMatch.__PropertyOffset_Expressions, this));
				}
				return result;
			}
			set
			{
				this.Expressions.CopyAssign(value);
			}
		}

		// Token: 0x0601295B RID: 76123 RVA: 0x001B579F File Offset: 0x001B399F
		static UEditableGameplayTagQueryExpression_AllExprMatch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.EditableGameplayTagQueryExpression_AllExprMatch");
		}

		// Token: 0x0601295C RID: 76124 RVA: 0x001B57AD File Offset: 0x001B39AD
		protected UEditableGameplayTagQueryExpression_AllExprMatch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009ED0 RID: 40656
		public new const string __ObjectPath = "/Script/GameplayTags.EditableGameplayTagQueryExpression_AllExprMatch";

		// Token: 0x04009ED1 RID: 40657
		private static IntPtr _ClassPtr;

		// Token: 0x04009ED2 RID: 40658
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009ED3 RID: 40659
		internal static int __PropertyOffset_Expressions;

		// Token: 0x04009ED4 RID: 40660
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UEditableGameplayTagQueryExpression> _Expressions;
	}
}
