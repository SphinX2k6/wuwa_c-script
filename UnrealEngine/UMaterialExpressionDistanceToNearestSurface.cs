using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DBA RID: 3514
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDistanceToNearestSurface")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionDistanceToNearestSurface : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BEDC RID: 48860 RVA: 0x00111811 File Offset: 0x0010FA11
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDistanceToNearestSurface._ClassPtr;
		}

		// Token: 0x0600BEDD RID: 48861 RVA: 0x00111820 File Offset: 0x0010FA20
		public UMaterialExpressionDistanceToNearestSurface() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDistanceToNearestSurface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BEDE RID: 48862 RVA: 0x00111848 File Offset: 0x0010FA48
		public UMaterialExpressionDistanceToNearestSurface(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDistanceToNearestSurface.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x0600BEDF RID: 48863 RVA: 0x0011187C File Offset: 0x0010FA7C
		// (set) Token: 0x0600BEE0 RID: 48864 RVA: 0x001118B5 File Offset: 0x0010FAB5
		public FExpressionInput Position
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Position) == null)
				{
					result = (this._Position = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionDistanceToNearestSurface.__PropertyOffset_Position, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionDistanceToNearestSurface.__PropertyOffset_Position, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BEE1 RID: 48865 RVA: 0x001118D6 File Offset: 0x0010FAD6
		static UMaterialExpressionDistanceToNearestSurface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDistanceToNearestSurface");
		}

		// Token: 0x0600BEE2 RID: 48866 RVA: 0x001118E4 File Offset: 0x0010FAE4
		protected UMaterialExpressionDistanceToNearestSurface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064F4 RID: 25844
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDistanceToNearestSurface";

		// Token: 0x040064F5 RID: 25845
		private static IntPtr _ClassPtr;

		// Token: 0x040064F6 RID: 25846
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040064F7 RID: 25847
		internal static int __PropertyOffset_Position;

		// Token: 0x040064F8 RID: 25848
		[Nullable(2)]
		private FExpressionInput _Position;
	}
}
