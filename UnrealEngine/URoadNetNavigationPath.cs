using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026D1 RID: 9937
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RoadNetNavigationRuntime.RoadNetNavigationPath")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class URoadNetNavigationPath : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E38 RID: 151096 RVA: 0x00369084 File Offset: 0x00367284
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoadNetNavigationPath._ClassPtr;
		}

		// Token: 0x06024E39 RID: 151097 RVA: 0x00369090 File Offset: 0x00367290
		public URoadNetNavigationPath() : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationPath.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E3A RID: 151098 RVA: 0x003690B8 File Offset: 0x003672B8
		public URoadNetNavigationPath(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationPath.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E75 RID: 36469
		// (get) Token: 0x06024E3B RID: 151099 RVA: 0x003690EC File Offset: 0x003672EC
		// (set) Token: 0x06024E3C RID: 151100 RVA: 0x00369125 File Offset: 0x00367325
		public TArray<FVector> PathPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PathPoints) == null)
				{
					result = (this._PathPoints = new TArray<FVector>(base.NativePtr + (IntPtr)URoadNetNavigationPath.__PropertyOffset_PathPoints, this));
				}
				return result;
			}
			set
			{
				this.PathPoints.CopyAssign(value);
			}
		}

		// Token: 0x17008E76 RID: 36470
		// (get) Token: 0x06024E3D RID: 151101 RVA: 0x00369133 File Offset: 0x00367333
		// (set) Token: 0x06024E3E RID: 151102 RVA: 0x00369143 File Offset: 0x00367343
		public unsafe float Length
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetNavigationPath.__PropertyOffset_Length);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetNavigationPath.__PropertyOffset_Length) = value;
			}
		}

		// Token: 0x17008E77 RID: 36471
		// (get) Token: 0x06024E3F RID: 151103 RVA: 0x00369154 File Offset: 0x00367354
		// (set) Token: 0x06024E40 RID: 151104 RVA: 0x00369164 File Offset: 0x00367364
		public unsafe bool IsPartial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetNavigationPath.__PropertyOffset_IsPartial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetNavigationPath.__PropertyOffset_IsPartial) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024E41 RID: 151105 RVA: 0x00369175 File Offset: 0x00367375
		static URoadNetNavigationPath()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RoadNetNavigationRuntime.RoadNetNavigationPath");
		}

		// Token: 0x06024E42 RID: 151106 RVA: 0x00369183 File Offset: 0x00367383
		protected URoadNetNavigationPath(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013DF2 RID: 81394
		public new const string __ObjectPath = "/Script/RoadNetNavigationRuntime.RoadNetNavigationPath";

		// Token: 0x04013DF3 RID: 81395
		private static IntPtr _ClassPtr;

		// Token: 0x04013DF4 RID: 81396
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013DF5 RID: 81397
		internal static int __PropertyOffset_PathPoints;

		// Token: 0x04013DF6 RID: 81398
		[Nullable(2)]
		private TArray<FVector> _PathPoints;

		// Token: 0x04013DF7 RID: 81399
		internal static int __PropertyOffset_Length;

		// Token: 0x04013DF8 RID: 81400
		internal static int __PropertyOffset_IsPartial;
	}
}
