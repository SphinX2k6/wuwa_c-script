using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D8B RID: 3467
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionArctangentFast")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionArctangentFast : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD41 RID: 48449 RVA: 0x0010EA65 File Offset: 0x0010CC65
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionArctangentFast._ClassPtr;
		}

		// Token: 0x0600BD42 RID: 48450 RVA: 0x0010EA74 File Offset: 0x0010CC74
		public UMaterialExpressionArctangentFast() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArctangentFast.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD43 RID: 48451 RVA: 0x0010EA9C File Offset: 0x0010CC9C
		public UMaterialExpressionArctangentFast(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionArctangentFast.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x0600BD44 RID: 48452 RVA: 0x0010EAD0 File Offset: 0x0010CCD0
		// (set) Token: 0x0600BD45 RID: 48453 RVA: 0x0010EB09 File Offset: 0x0010CD09
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionArctangentFast.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionArctangentFast.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BD46 RID: 48454 RVA: 0x0010EB2A File Offset: 0x0010CD2A
		static UMaterialExpressionArctangentFast()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionArctangentFast");
		}

		// Token: 0x0600BD47 RID: 48455 RVA: 0x0010EB38 File Offset: 0x0010CD38
		protected UMaterialExpressionArctangentFast(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063DC RID: 25564
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionArctangentFast";

		// Token: 0x040063DD RID: 25565
		private static IntPtr _ClassPtr;

		// Token: 0x040063DE RID: 25566
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040063DF RID: 25567
		internal static int __PropertyOffset_Input;

		// Token: 0x040063E0 RID: 25568
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
