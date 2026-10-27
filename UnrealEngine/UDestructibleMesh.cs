using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000355 RID: 853
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleMesh")]
	[UnrealStructLayout(5136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 5136)]
	public class UDestructibleMesh : USkeletalMesh, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002F65 RID: 12133 RVA: 0x00048922 File Offset: 0x00046B22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDestructibleMesh._ClassPtr;
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x00048930 File Offset: 0x00046B30
		public UDestructibleMesh() : this(BuiltinUtils.AllocNativeUObject(UDestructibleMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002F67 RID: 12135 RVA: 0x00048958 File Offset: 0x00046B58
		public UDestructibleMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDestructibleMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002F68 RID: 12136 RVA: 0x0004898C File Offset: 0x00046B8C
		// (set) Token: 0x06002F69 RID: 12137 RVA: 0x000489C5 File Offset: 0x00046BC5
		public FDestructibleParameters DefaultDestructibleParameters
		{
			get
			{
				base.FastCheckIsValid();
				FDestructibleParameters result;
				if ((result = this._DefaultDestructibleParameters) == null)
				{
					result = (this._DefaultDestructibleParameters = new FDestructibleParameters(base.NativePtr + (IntPtr)UDestructibleMesh.__PropertyOffset_DefaultDestructibleParameters, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDestructibleParameters.StaticStruct(), base.NativePtr + (IntPtr)UDestructibleMesh.__PropertyOffset_DefaultDestructibleParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x000489E8 File Offset: 0x00046BE8
		// (set) Token: 0x06002F6B RID: 12139 RVA: 0x00048A21 File Offset: 0x00046C21
		public TArray<FFractureEffect> FractureEffects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFractureEffect> result;
				if ((result = this._FractureEffects) == null)
				{
					result = (this._FractureEffects = new TArray<FFractureEffect>(base.NativePtr + (IntPtr)UDestructibleMesh.__PropertyOffset_FractureEffects, this));
				}
				return result;
			}
			set
			{
				this.FractureEffects.CopyAssign(value);
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002F6C RID: 12140 RVA: 0x00048A2F File Offset: 0x00046C2F
		// (set) Token: 0x06002F6D RID: 12141 RVA: 0x00048A43 File Offset: 0x00046C43
		[Nullable(2)]
		public unsafe UStaticMesh StaticMeshProxy
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UDestructibleMesh.__PropertyOffset_StaticMeshProxy);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDestructibleMesh.__PropertyOffset_StaticMeshProxy, value);
			}
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x00048A58 File Offset: 0x00046C58
		static UDestructibleMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ApexDestruction.DestructibleMesh");
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x00048A66 File Offset: 0x00046C66
		protected UDestructibleMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001476 RID: 5238
		public new const string __ObjectPath = "/Script/ApexDestruction.DestructibleMesh";

		// Token: 0x04001477 RID: 5239
		private static IntPtr _ClassPtr;

		// Token: 0x04001478 RID: 5240
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001479 RID: 5241
		internal static int __PropertyOffset_DefaultDestructibleParameters;

		// Token: 0x0400147A RID: 5242
		[Nullable(2)]
		private FDestructibleParameters _DefaultDestructibleParameters;

		// Token: 0x0400147B RID: 5243
		internal static int __PropertyOffset_FractureEffects;

		// Token: 0x0400147C RID: 5244
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFractureEffect> _FractureEffects;

		// Token: 0x0400147D RID: 5245
		internal static int __PropertyOffset_StaticMeshProxy;
	}
}
