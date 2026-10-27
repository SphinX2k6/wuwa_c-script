using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001220 RID: 4640
	[UnrealObjectPath("/Script/Engine.VectorField")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UVectorField : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011141 RID: 69953 RVA: 0x0019103F File Offset: 0x0018F23F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UVectorField._ClassPtr;
		}

		// Token: 0x06011142 RID: 69954 RVA: 0x0019104C File Offset: 0x0018F24C
		public UVectorField() : this(BuiltinUtils.AllocNativeUObject(UVectorField.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011143 RID: 69955 RVA: 0x00191074 File Offset: 0x0018F274
		[NullableContext(1)]
		public UVectorField(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UVectorField.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x06011144 RID: 69956 RVA: 0x001910A7 File Offset: 0x0018F2A7
		// (set) Token: 0x06011145 RID: 69957 RVA: 0x001910BB File Offset: 0x0018F2BB
		public unsafe FBox Bounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorField.__PropertyOffset_Bounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorField.__PropertyOffset_Bounds) = value;
			}
		}

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x06011146 RID: 69958 RVA: 0x001910D0 File Offset: 0x0018F2D0
		// (set) Token: 0x06011147 RID: 69959 RVA: 0x001910E0 File Offset: 0x0018F2E0
		public unsafe float Intensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UVectorField.__PropertyOffset_Intensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UVectorField.__PropertyOffset_Intensity) = value;
			}
		}

		// Token: 0x06011148 RID: 69960 RVA: 0x001910F1 File Offset: 0x0018F2F1
		static UVectorField()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.VectorField");
		}

		// Token: 0x06011149 RID: 69961 RVA: 0x001910FF File Offset: 0x0018F2FF
		protected UVectorField(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009249 RID: 37449
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.VectorField";

		// Token: 0x0400924A RID: 37450
		private static IntPtr _ClassPtr;

		// Token: 0x0400924B RID: 37451
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400924C RID: 37452
		internal static int __PropertyOffset_Bounds;

		// Token: 0x0400924D RID: 37453
		internal static int __PropertyOffset_Intensity;
	}
}
