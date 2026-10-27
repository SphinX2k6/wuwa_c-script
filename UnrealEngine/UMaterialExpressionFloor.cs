using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DC6 RID: 3526
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFloor")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionFloor : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF40 RID: 48960 RVA: 0x001123CD File Offset: 0x001105CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFloor._ClassPtr;
		}

		// Token: 0x0600BF41 RID: 48961 RVA: 0x001123DC File Offset: 0x001105DC
		public UMaterialExpressionFloor() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFloor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF42 RID: 48962 RVA: 0x00112404 File Offset: 0x00110604
		public UMaterialExpressionFloor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFloor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C53 RID: 11347
		// (get) Token: 0x0600BF43 RID: 48963 RVA: 0x00112438 File Offset: 0x00110638
		// (set) Token: 0x0600BF44 RID: 48964 RVA: 0x00112471 File Offset: 0x00110671
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFloor.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFloor.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BF45 RID: 48965 RVA: 0x00112492 File Offset: 0x00110692
		static UMaterialExpressionFloor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFloor");
		}

		// Token: 0x0600BF46 RID: 48966 RVA: 0x001124A0 File Offset: 0x001106A0
		protected UMaterialExpressionFloor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400653A RID: 25914
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFloor";

		// Token: 0x0400653B RID: 25915
		private static IntPtr _ClassPtr;

		// Token: 0x0400653C RID: 25916
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400653D RID: 25917
		internal static int __PropertyOffset_Input;

		// Token: 0x0400653E RID: 25918
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
